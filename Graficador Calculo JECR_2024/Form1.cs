using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.CodeDom.Compiler;
using System.Reflection;
using MathNet.Numerics;
using MathNet.Numerics.RootFinding;
using MathNet.Numerics.Optimization;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.FSharp.Core.ByRefKinds;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;





namespace Graficador_Calculo_JECR_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Draw the graph.
        private void btnGraph_Click(object sender, EventArgs e)
        {
            MakeGraph();
        }
        

        // Make the graph.
        private void MakeGraph()
        {



            // Get the bounds.
            float xmin = float.Parse(txtXmin.Text);
            float xmax = float.Parse(txtXmax.Text);
            float ymin = float.Parse(txtYmin.Text);
            float ymax = float.Parse(txtYmax.Text);

            // Make the Bitmap.
            int wid = picGraph.ClientSize.Width;
            int hgt = picGraph.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {

                // Compile the function.
                MethodInfo function = null;
                try
                {
                    function = CompileFunction(txtEquation.Text);
                }
                catch (Exception ex)
                {
                    // If we couldn't compile the code, give up.
                    MessageBox.Show(ex.Message, "Expression Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                //Maximo Y minimo
                float start = -100;
                float end = 100;
                float step = 1;

                float min = float.MaxValue;
                float max = float.MinValue;
                float minX = start;
                float maxX = start;

                for (float x = start; x <= end; x += step)
                {
                    float y = F(function, x);

                    if (y < min)
                    {
                        min = y;
                        minX = x;
                    }

                    if (y > max)
                    {
                        max = y;
                        maxX = x;
                    }
                }

                //Checa si el rango manual esta desactivado
                if (cBoxRangoManual.Checked != true)
                {
                    //xmin = (minX + float.Parse(txtRangoAuto.Text)) * -1;
                    //xmax = maxX + float.Parse(txtRangoAuto.Text);
                    //ymin = (min + float.Parse(txtRangoAuto.Text)) * -1;
                    //ymax = max + float.Parse(txtRangoAuto.Text);

                    txtXmin.Text = Convert.ToString((minX + float.Parse(txtRangoAuto.Text)) * -1);
                    txtXmax.Text = Convert.ToString((minX + float.Parse(txtRangoAuto.Text)));

                    // txtXmax.Text = Convert.ToString((maxX + float.Parse(txtRangoAuto.Text)));

                    txtYmin.Text = Convert.ToString((minX + float.Parse(txtRangoAuto.Text)) * -1);
                    txtYmax.Text = Convert.ToString((minX + float.Parse(txtRangoAuto.Text)));

                    // txtYmax.Text = Convert.ToString(((max + float.Parse(txtRangoAuto.Text))));

                    xmin = float.Parse(txtXmin.Text);
                    xmax = float.Parse(txtXmax.Text);
                    ymin = float.Parse(txtYmin.Text);
                    ymax = float.Parse(txtYmax.Text);

                    if (xmin>xmax)
                    {
                        txtXmin.Text = Convert.ToString(xmin * -1);
                        txtXmax.Text = Convert.ToString(xmax * -1);
                        xmin = float.Parse(txtXmin.Text);
                        xmax = float.Parse(txtXmax.Text);

                    }
                    if (ymin>ymax)
                    {
                        txtYmin.Text = Convert.ToString(ymin * -1);
                        txtYmax.Text = Convert.ToString(ymax * -1);
                        ymin = float.Parse(txtYmin.Text);
                        ymax = float.Parse(txtYmax.Text);
                    }

                    
                    
                }
                //MessageBox.Show($"Minimum value: {min} at x = {minX}");
                //MessageBox.Show($"Maximum value: {max} at x = {maxX}");

                dgvTablaXY.Rows.Clear();

                // Calcular Tabla
                for (float x = xmin; x <= xmax; x++)
                {
                    float y = F(function, x);
                    dgvTablaXY.Rows.Add(x, y);
                }

                gr.SmoothingMode = SmoothingMode.AntiAlias;

                // Transform to map the graph bounds to the Bitmap.
                RectangleF rect = new RectangleF(xmin, ymin, xmax - xmin, ymax - ymin);
                PointF[] pts =
                {
                    new PointF(0, hgt),
                    new PointF(wid, hgt),
                    new PointF(0, 0),
                };
                gr.Transform = new Matrix(rect, pts);

                // Draw the graph.
                using (Pen graph_pen = new Pen(Color.Blue, 0))
                {
                    // Draw the axes.
                    gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                    gr.DrawLine(graph_pen, 0, ymin, 0, ymax);

                    //Genera las axis de X
                    for (float i = xmin + 1; i <= xmax; i++)
                    {
                        gr.DrawLine(graph_pen, i, .5f, i, -.5f);
                    }

                    //Genera las axis de Y
                    for (float i = ymin + 1; i <= ymax - 1; i++)
                    {
                        gr.DrawLine(graph_pen, .5f, i, -.5f, i);
                    }

                    graph_pen.Color = Color.Red;

                    // See how big 1 pixel is horizontally.
                    Matrix inverse = gr.Transform;
                    inverse.Invert();
                    PointF[] pixel_pts =
                    {
                        new PointF(0, 0),
                        new PointF(1, 0)
                    };
                    inverse.TransformPoints(pixel_pts);
                    float dx = pixel_pts[1].X - pixel_pts[0].X;
                    dx /= 2;

                    

                    // Loop over x values to generate points.
                    List<PointF> points = new List<PointF>();
                    for (float x = xmin; x <= xmax; x += dx)
                    {


                        bool valid_point = false;
                        try
                        {
                            // Get the next point.
                            float y = F(function, x);
                            //double ydouble = FResultado(function, x);
                            // MessageBox.Show(ydouble.ToString());

                            // If the slope is reasonable, this is a valid point.
                            if (points.Count == 0) valid_point = true;
                            else
                            {
                                float dy = y - points[points.Count - 1].Y;
                                if (Math.Abs(dy / dx) < 1000) valid_point = true;
                            }
                            if (valid_point)
                            {
                                points.Add(new PointF(x, y));
                                //dgvTablaXY.Rows.Add(x, y);
                                //if (dgvTablaXY.Rows.Count >= 3)
                                //{
                                //    // Get the last row and the one before the last
                                //    DataGridViewRow ultima_X = dgvTablaXY.Rows[dgvTablaXY.Rows.Count - 2];
                                //    DataGridViewRow penultima_X = dgvTablaXY.Rows[dgvTablaXY.Rows.Count - 3];

                                //    bool X_iguales = true;
                                //    for (int i = 0; i < dgvTablaXY.Columns.Count; i++)
                                //    {
                                //        var ultima_X_valor = ultima_X.Cells[0].Value?.ToString();
                                //        var penulltima_X_valor = penultima_X.Cells[0].Value?.ToString();

                                //        if (ultima_X_valor != penulltima_X_valor)
                                //        {
                                //            X_iguales = false;
                                //            break;
                                //        }
                                //    }

                                //    if (X_iguales)
                                //    {
                                //        dgvTablaXY.Rows.Remove(ultima_X);
                                //    }

                                //}
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error evaluating function.\n" + ex.Message,
                                "Error Evaluating Function", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                        // If the new point is invalid, draw
                        // the points in the latest batch.
                        if (!valid_point)
                        {
                            if (points.Count > 1) gr.DrawLines(graph_pen, points.ToArray());
                            points.Clear();
                        }
                    }

                    // Draw the last batch of points.
                    if (points.Count > 1) gr.DrawLines(graph_pen, points.ToArray());

                }
                

            }
            // Display the result.
            picGraph.Image = bm;

            //Transfiere la ecuación a los lables como muestra de lo calculado en la grafica
            try
            {
                string input = txtEquation.Text;
                string output = TransformMathPow(input);

                var variable = Expr.Variable("x");

                var parsedFunction = Expr.Parse(output);
                lblEcuacion.Text = "f(x) = " + TransformMultiplication(parsedFunction.ToString());

                var derivative = parsedFunction.Differentiate(variable);

                lblDerivada.Text = "f'(x) = " + TransformMultiplication(derivative.ToString());

                lblPendiente0.Text = "Pendiente 0:";
            }
            catch (Exception)
            {
                lblEcuacion.Text = "f(x) = ";
                lblDerivada.Text = "f'(x) = ";
            }
        }

        // The function to graph.
        private float F(MethodInfo function, float x)
        {
            double result = (double)function.Invoke(null, new object[] { x });
            return (float)result;
        }

        // Calcular el valor del resultado
        private double FResultado(MethodInfo function, float x)
        {
            double result = (double)function.Invoke(null, new object[] { x });
            return result;
        }

        // Compile the function and return a MethodInfo to execute it.
        private MethodInfo CompileFunction(string equation_text)
        {
            // Turn the equation into a function.
            string function_text =
                "using System;" +
                "public static class Evaluator" +
                "{" +
                "    public static double Evaluate(double x)" +
                "    {" +
                "        return " + equation_text + ";" +
                "    }" +
                "}";

            // Compile the function.
            CodeDomProvider code_provider = CodeDomProvider.CreateProvider("C#");

            // Generate a non-executable assembly in memory.
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = false;

            // Compile the code.
            CompilerResults results =
                code_provider.CompileAssemblyFromSource(parameters, function_text);

            // If there are errors, display them.
            if (results.Errors.Count > 0)
            {
                string msg = "Error compiling the expression.";
                foreach (CompilerError compiler_error in results.Errors)
                {
                    msg += "\n" + compiler_error.ErrorText;
                }
                throw new InvalidProgramException(msg);
            }
            else
            {
                // Get the Evaluator class type.
                Type evaluator_type = results.CompiledAssembly.GetType("Evaluator");

                // Get a MethodInfo object describing the Evaluate method.
                return evaluator_type.GetMethod("Evaluate");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeGraph();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MakeGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MethodInfo function = null;
            try
            {
                function = CompileFunction(txtEquation.Text);
            }
            catch (Exception ex)
            {
                // If we couldn't compile the code, give up.
                MessageBox.Show(ex.Message, "Expression Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                if (txtDerivada.Text != "")
                {
                    // Read the text from the TextBox
                    string derivada = txtDerivada.Text;

                    // Parse the equation to get coefficients
                    var coefficients = ParseEquation(derivada);

                    double a = coefficients.Item1;
                    double b = coefficients.Item2;
                    double c = coefficients.Item3;
                   // MessageBox.Show(a.ToString()+ b.ToString() + c.ToString());
                    lblPendiente0.Text = "Pendiente 0:";
                    if (a == 0)
                    { // ax +b
                        if (b != 0)
                        {
                            double x = -c / b;
                           // MessageBox.Show("The value of x is: " + x);

                            if ((b*(x+1) + c) > 0 && (b * (x - 1) + c) < 0) // Checa si Minima
                            {
                                lblPendiente0.Text += "\nx = " + x;
                                lblPendiente0.Text += "\nEs Minima.";

                                float y = F(function, float.Parse(x.ToString())); // calcula la funcion en terminos de x
                                lblPendiente0.Text += "\nf("+x+") = "+ y ;

                            }
                            else if ((b * (x + 1) + c) < 0 && (b * (x - 1) + c) > 0) // Checa si Maxima
                            {
                                lblPendiente0.Text += "\nx = " + x;
                                lblPendiente0.Text += "\nEs Maxima.";

                                float y = F(function, float.Parse(x.ToString())); // calcula la funcion en terminos de x
                                lblPendiente0.Text += "\nf(" + x + ") = " + y;
                            }
                            else
                            {
                                lblPendiente0.Text = "No posee maxima o minima.";
                            }
                        }
                        else
                        {
                            lblPendiente0.Text = "No posee maxima o minima.";
                        }
                    }
                    else
                    { // ax^2 + bx + c
                        // Calculate the discriminant
                        double discriminant = Math.Pow(b, 2) - 4 * a * c;


                        // Check if the discriminant is non-negative
                        if (discriminant >= 0)
                        {
                            // Calculate the two roots
                            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                            //MessageBox.Show($"The roots are real and different:\nx1 = {x1}\nx2 = {x2}");

                            float y = F(function, float.Parse(x1.ToString())); // calcula la funcion en terminos de x
                            float y2 = F(function, float.Parse(x2.ToString())); // calcula la funcion en terminos de x

                            if (y > y2)
                            {
                                lblPendiente0.Text += "\nx1 = " + x1;
                                lblPendiente0.Text += "\nEs Maxima.";
                                lblPendiente0.Text += "\nf(" + x1 + ") = " + y + "\n";

                                lblPendiente0.Text += "\nx2 = " + x2;
                                lblPendiente0.Text += "\nEs Minima.";
                                lblPendiente0.Text += "\nf(" + x2 + ") = " + y2;
                            }else if (y < y2)
                            {
                                lblPendiente0.Text += "\nx1 = " + x1;
                                lblPendiente0.Text += "\nEs Minima.";
                                lblPendiente0.Text += "\nf(" + x1 + ") = " + y + "\n";

                                lblPendiente0.Text += "\nx2 = " + x2;
                                lblPendiente0.Text += "\nEs Maxima.";
                                lblPendiente0.Text += "\nf(" + x2 + ") = " + y2;
                            }

                            //if ((a * (Math.Pow(x1+.1f, 2)) + (b*x1+.1f) + c) < 0 && (a * (Math.Pow(x1 - .1f, 2)) + (b * x1 - .1f) + c) > 0) //Checa si x1 minima
                            //{
                            //    lblPendiente0.Text += "\nx1 = " + x1;
                            //    lblPendiente0.Text += "\nEs Minima.";

                            //    float y = F(function, float.Parse(x1.ToString())); // calcula la funcion en terminos de x
                            //    lblPendiente0.Text += "\nf(" + x1 + ") = " + y +"\n";

                            //    lblPendiente0.Text += "\nx2 = " + x2;
                            //    lblPendiente0.Text += "\nEs Maxima.";

                            //    float y2 = F(function, float.Parse(x2.ToString())); // calcula la funcion en terminos de x
                            //    lblPendiente0.Text += "\nf(" + x2 + ") = " + y2;

                            //    //if ((a * (Math.Pow(x2 + .1f, 2)) + (b * x2 + .1f) + c) > 0 && (a * (Math.Pow(x2 - .1f, 2)) + (b * x1 - .1f) + c) < 0)//Checa si x2 maxima
                            //    //{
                            //    //    lblPendiente0.Text += "\nx2 = " + x2;
                            //    //    lblPendiente0.Text += "\nEs Maxima.";

                            //    //    float y2 = F(function, float.Parse(x2.ToString())); // calcula la funcion en terminos de x
                            //    //    lblPendiente0.Text += "\nf(" + x2 + ") = " + y2;
                            //    //} 

                            //}else if ((a * (Math.Pow(x1 + .1f, 2)) + (b * x1 + .1f) + c) > 0 && (a * (Math.Pow(x1 - .1f, 2)) + (b * x1 - .1f) + c) < 0)//Checa si x1 maxima
                            //{
                            //    lblPendiente0.Text += "\nx1 = " + x1;
                            //    lblPendiente0.Text += "\nEs Maxima.";

                            //    float y = F(function, float.Parse(x1.ToString())); // calcula la funcion en terminos de x
                            //    lblPendiente0.Text += "\nf(" + x1 + ") = " + y + "\n"; ;

                            //    lblPendiente0.Text += "\nx2 = " + x2;
                            //    lblPendiente0.Text += "\nEs Minima.";

                            //    float y2 = F(function, float.Parse(x2.ToString())); // calcula la funcion en terminos de x
                            //    lblPendiente0.Text += "\nf(" + x2 + ") = " + y2;

                            //    //if ((a * (Math.Pow(x2 + .1f, 2)) + (b * x2 + .1f) + c) < 0 && (a * (Math.Pow(x2 - .1f, 2)) + (b * x2 - .1f) + c) > 0)//Checa si x2 minima
                            //    //{
                            //    //    lblPendiente0.Text += "\nx2 = " + x2;
                            //    //    lblPendiente0.Text += "\nEs Minima.";

                            //    //    float y2 = F(function, float.Parse(x2.ToString())); // calcula la funcion en terminos de x
                            //    //    lblPendiente0.Text += "\nf(" + x2 + ") = " + y2;
                            //    //}
                            //}
                            //else
                            //{
                            //    lblPendiente0.Text = "No posee maxima o minima.";
                            //}

                        }
                        else
                        {
                            //// Calculate the real and imaginary parts of the roots
                            double realPart = -b / (2 * a);
                            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

                            MessageBox.Show($"The roots are complex and different:\nx1 = {realPart} + {imaginaryPart}i\nx2 = {realPart} - {imaginaryPart}i");
                        }
                    }



                }
                else
                {
                    MessageBox.Show("Ingrese la derivada en formato ax^2 + ax + c o ax +b");
                }

            }
            catch (Exception ex)
            {
                // Handle any errors, such as invalid input
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cBoxRangoManual_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxRangoManual.Checked)
            {
                txtXmax.Enabled = true;
                txtXmin.Enabled = true;
                txtYmax.Enabled = true;
                txtYmin.Enabled = true;
                txtRangoAuto.Enabled = false;

            }else
            {
                txtXmax.Enabled = false;
                txtXmin.Enabled = false;
                txtYmax.Enabled = false;
                txtYmin.Enabled = false;
                txtRangoAuto.Enabled = true;
            }
        }

        //Pasa De Math.Pow(x,n) a x^n
        static string TransformMathPow(string input)
        {
            // Regular expression to match Math.Pow(x, 2)
            var regex = new Regex(@"Math\.Pow\(([^,]+),\s*(\d+)\)");

            // Replace the matched pattern with x^2
            return regex.Replace(input, m => $"{m.Groups[1].Value}^{m.Groups[2].Value}");
        }

        static string TransformMultiplication(string input)
        {
            // Regular expression to match patterns like "number*variable"
            var regex = new Regex(@"(\d+)\*(\w+)");

            // Replace "number*variable" with "numbervariable"
            return regex.Replace(input, "$1$2");
        }

        //Separa el texto en a b c para la formula general
        private Tuple<double, double, double> ParseEquation(string input)
        {
            // Remove spaces for easier parsing
            input = input.Replace(" ", "");

            // Initialize default coefficients
            double a = 0;
            double b = 0;
            double c = 0;

            // Define regular expressions for matching the coefficients
            string patternA = @"^([+-]?\d*\.?\d*)x\^2";
            string patternB = @"([+-]?\d*\.?\d*)x(?!\^2)"; // Ensure it's not x^2
            string patternC = @"([+-]?\d+\.?\d*)$";

            // Extract coefficients using regex
            Match matchA = Regex.Match(input, patternA);
            if (matchA.Success)
            {
                a = string.IsNullOrEmpty(matchA.Groups[1].Value) ? 1 : double.Parse(matchA.Groups[1].Value);
            }

            Match matchB = Regex.Match(input, patternB);
            if (matchB.Success)
            {
                b = string.IsNullOrEmpty(matchB.Groups[1].Value) ? 1 : double.Parse(matchB.Groups[1].Value);
            }

            Match matchC = Regex.Match(input, patternC);
            if (matchC.Success)
            {
                c = double.Parse(matchC.Groups[1].Value);
            }

            // Special handling for the constant term (c) if x^2 is missing
            if (input.Contains("x^2") && !input.Contains("x"))
            {
                c = 0;
            }

            // Return coefficients as a tuple
            return new Tuple<double, double, double>(a, b, c);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            txtEquation.Text += "Math.Pow(x,n)";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            txtEquation.Text += "Math.Sqrt(x)";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            txtEquation.Text += "Math.Log10(x)";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEquation.Clear();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            txtEquation.Text += "Math.Exp(x)";
        }
    }
    
}
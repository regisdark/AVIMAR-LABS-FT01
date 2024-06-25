namespace AVIMAR_LABS_FT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                //clear values at data grid
                //limpia los registros actuales en el listado principal
                dtSimulation.Rows.Clear();
                rTextlog.Clear();

                //let's define a variable for accumulated capital
                //definamos una variable para el acumulado del capital
                decimal _ac = numCapital.Value;

                //lets simulate capital based in: interest rate, capital & cycle count
                //simulemos el capital basado en: tasa de interés, capital y cantidad de ciclos
                for (int i = 0; i < NumCycCount.Value; i++)
                {
                    //we are calculating interest profit based in provied parameters
                    //estamos calculando la ganancia de interés basados en los parámetros provistos
                    var _g = (_ac / 100) * NumIntRate.Value;

                    //let's accumulate profits
                    //acumulamos la ganancia acumulada
                    _ac = _g + _ac;

                    //let's apply a human format to generated data for easy understanding
                    //apliquemos un formato más humano a la información generada para una fácil interpretación
                    dtSimulation.Rows.Add((i + 1).ToString(), Math.Round(_g, 3).ToString("C"), _ac.ToString("C"));

                    //generate log detail
                    //genera el registro
                    rTextlog.AppendText(Environment.NewLine + string.Format("Cycle: {0} Capital: {1} Interest: {2} ", (i + 1).ToString(), _ac.ToString("C"), Math.Round(_g, 3).ToString("C")));
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}

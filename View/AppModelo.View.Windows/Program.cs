using AppModelo.View.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Adicionar manipulador para lidar com a exceção gerada pelos threads principais
            Application.ThreadException +=
            new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            //Adicionar manipulador para lidar com a exceção gerada pelos threads adicionais
            AppDomain.CurrentDomain.UnhandledException +=
            new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

            Environment.Exit(-1);


        }

        static void Application_ThreadException
        (object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // Todas as exceções lançadas pelo thread principal são tratadas por este método
            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException
            (object sender, UnhandledExceptionEventArgs e)
        {
            //Todas as exceções lançadas por threads adicionais são tratadas neste método
            ShowExceptionDetails(e.ExceptionObject as Exception);

            //Suspenda o thread atual por enquanto para impedir que a exceção seja lançada.
            Thread.CurrentThread.Suspend();
        }

        static void ShowExceptionDetails(Exception Ex)
        {
            MessageBox.Show(Ex.Message, Ex.TargetSite.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

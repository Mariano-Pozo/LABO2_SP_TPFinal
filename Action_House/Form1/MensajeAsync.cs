namespace Form1
{

    public class MensajeAsync
    {
        public static void ConfirmacionCierre()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            Thread thread = new Thread(() =>
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de querer cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cancellationTokenSource.Cancel();
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    cancellationTokenSource.Cancel();
                }
            });

            thread.Start();

            // Hilo para esperar 10 segundos
            Thread esperarHilo = new Thread(() =>
            {
                try
                {
                    Thread.Sleep(10000); // Esperar 10 segundos
                    if (!cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        MessageBox.Show("Tiempo agotado. La aplicación se cerrará.");
                        Application.Exit();
                    }
                }
                catch (ThreadInterruptedException)
                {
                    // El hilo fue interrumpido, no hacer nada
                }
            });

            esperarHilo.Start();

            thread.Join(); // Esperar a que el hilo de la confirmación termine antes de continuar
        }
    }
}

namespace QuanLySanPhamCSDL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            frmDangNhap frmDN=new frmDangNhap();
            DialogResult ret= frmDN.ShowDialog();
            if(ret == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }            
        }
    }
}
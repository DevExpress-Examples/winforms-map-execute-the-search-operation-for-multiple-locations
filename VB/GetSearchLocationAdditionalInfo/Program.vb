Imports DevExpress.XtraEditors
Imports System.Linq
Imports System.Windows.Forms

Namespace GetSearchLocationAdditionalInfo

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call WindowsFormsSettings.SetPerMonitorDpiAware()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Module
End Namespace

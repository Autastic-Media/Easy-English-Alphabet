Imports System.IO
Imports System.Reflection
Imports System.Version

Namespace Security
    Public Class Globals

        'Path where the licence will be saved
        '''Public Shared LicencePath As String = Application.StartupPath
        Public Shared LicencePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), My.Application.Info.CompanyName, Assembly.GetCallingAssembly().GetName().Name)

        'Full path to the licence file
        Public Shared LicenceFile As String = Path.Combine(LicencePath, "licence.lic")

        'Computer name
        Public Shared ComputerName As String = Environment.MachineName

        'List of valid licence keys
        Public Shared LicenceKeys As New List(Of String)(
            New String() {
            "Gent",
            "y77K-1D3-3Ix2-3bvL-3Ubc",
            "693L-OM1t-j8EB-j0W0-dhZA",
            "X1E3-I2uS-Z97x-7FO-UvLM",
            "9OEE-V112-k012-79EU-4K3x",
            "DTvZ-KiAj-6VEa-nEI-JSf6",
            "H2A-OXE-DP2y-jao-UJYh",
            "sSYG-W992-FYl8-R9h7-nX76",
            "O7ve-k37X-njz-tC23-3tfT",
            "C76d-M0bE-MRB7-O2PD-6uVC",
            "j3WB-4xX3-InLC-8NTI-OhYv",
            "sDL-83LJ-A63j-PJBl-ODUk",
            "1Not-dOL3-prb1-sLNS-W973",
            "X00N-AZ80-oeDW-xP5x-bHK8",
            "6Ugp-SEar-d27-S7g6-4ySN",
            "nzjI-KC1-9WCX-816R-AyV0",
            "0ULV-mIWp-ZYf7-A5H5-s64p",
            "H77J-Vh6K-8pVX-55G-8S17",
            "XT6V-x5Ep-21T5-HRgb-wfDC",
            "SS05-9ohD-2An-9T84-lrgZ",
            "yER1-ulHx-46K5-FGaT-BRD3"})

    End Class
End Namespace

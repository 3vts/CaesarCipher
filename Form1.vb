Public Class Cipher
    Dim FILE_NAME As String = Application.StartupPath.ToString & "\textfile.txt"
    Private Sub Encrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encrypt.Click
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Dim Plain As String = objReader.ReadToEnd
        Dim xKalimat As String
        objReader.Close()
        For Each c As Char In Plain
            c = Chr((Asc(c) + Key.Text) Mod 256)
            xKalimat &= c
        Next
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
        objWriter.Write(xKalimat)
        objWriter.Close()
    End Sub
    Private Sub Decrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Decrypt.Click
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Dim Cipher As String = objReader.ReadToEnd
        Dim xkalimat As String
        objReader.Close()
        For Each c As Char In Cipher
            c = Chr((Asc(c) - Key.Text) Mod 256)
            xkalimat &= c
        Next
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
        objWriter.Write(xkalimat)
        objWriter.Close()
    End Sub
End Class
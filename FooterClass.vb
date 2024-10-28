Public Class FooterClass
    Inherits PdfPageEventHelper

    ' Declare fonts for footer text
    Private footerFont As iTextSharp.text.Font
    Public pageFont As iTextSharp.text.Font

    Dim employeeName As String
    ' Constructor to initialize fonts
    Public Sub New(empName As String)
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Dim fontPath As String = "\\Backroom_NAS\SkillsProfiling\Resources\Fonts\GothamBook.ttf"
        Dim bfGothamBook As BaseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
        footerFont = New iTextSharp.text.Font(bfGothamBook, 8, iTextSharp.text.Font.NORMAL)
        pageFont = New iTextSharp.text.Font(bfGothamBook, 8, iTextSharp.text.Font.NORMAL)
        Me.employeeName = empName
    End Sub

    ' Add footer on each page
    Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
        Dim cb As PdfContentByte = writer.DirectContent

        ' Get page dimensions
        Dim pageSize As iTextSharp.text.Rectangle = document.PageSize

        Dim footerText As New Phrase($"Skills Profile of {employeeName}", footerFont)
        ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, footerText, pageSize.GetLeft(40), pageSize.GetBottom(30), 0)
    End Sub
End Class

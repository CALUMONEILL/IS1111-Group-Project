Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_GRP_PROJ_AccessDataSet.tblTest' table. You can move, or remove it, as needed.
        Me.TblTestTableAdapter.Fill(Me.IS1111_GRP_PROJ_AccessDataSet.tblTest)










        'Calum 7/3/21 Some code I used for my login, I had three different users.
        'Maybe we could use something like this for each worker but each one has a different button to bring them to the right form.

        'eg if the operator logs in they get a button going to the product form. 
        'If the administrator logs in, the button that goes to the form where they can edit accounts is shown

        'Declare variables
        'Dim username, password As String


        'Assign variable to textbox
        'username = txtUsername.Text
        'password = txtPassword.Text


        'The application has user data for three phone operators, with one password for all three
        'Output to Textbox that the inputted details are correct or incorrect

        'If username = "John" And password = "Password" Then

        'This makes the button that takes the user to the next page visible

        '   btnAge.Visible = True
        '   txtPasswordVer.Text = "Successful Login - Welcome, John"

        'The following code is a repeat of the above but rewritten to allow for two extra operators

        'ElseIf username = "Paul" And password = "Password" Then
        '   btnAge.Visible = True
        '   txtPasswordVer.Text = "Successful Login - Welcome, Paul"

        'ElseIf username = "George" And password = "Password" Then
        '   btnAge.Visible = True
        '   txtPasswordVer.Text = "Successful Login - Welcome, George"

        'Else
        'If the incorrect password or an invalid username is inputted into the respective textboxes, the following message will appear in the bottom-most textbox

        '   txtPasswordVer.Text = "Invalid Details - Please try again"

        'This makes the button that takes the user to next page invisible

        '   btnAge.Visible = False
        'End If









    End Sub
End Class

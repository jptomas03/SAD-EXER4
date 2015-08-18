Public Class profile
    Dim Activities As New Collection
    Dim Sex As String
    Dim Level As String
    Dim act As String
    Private Sub profile_Load(sender As Object, e As EventArgs) Handles Me.Load
        Activities.Add(chkActRunning)
        Activities.Add(chkActBiking)
        Activities.Add(chkActWalking)
        Activities.Add(chkActSwimming)
        Activities.Add(chkActSkiing)
        Activities.Add(chkActInLineShaking)
    End Sub

    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        Dim i As Integer
        act = ""
        If optSexMale.Checked = True Then
            Sex = "He"
        Else
            Sex = "She"
        End If

        If optLevelBeginner.Checked = True Then
            Level = "beginner"
        ElseIf optLevelIntermediate.Checked = True Then
            Level = "intermediate"
        ElseIf optLevelAdvance.Checked = True Then
            Level = "advance"
        ElseIf optLevelExtreme.Checked = True Then
            Level = "extreme"
        End If

        For i = 1 To Activities.Count
            If Activities.Item(i).Checked = True Then
                act = act + Activities.Item(i).Text + vbLf
            End If
        Next

        MsgBox(txtName.Text + " is " + txtAge.Text + "." + vbLf + Sex + "lives in " + cboCity.Text + "." + vbLf + Sex + " is an " + Level + " level Athlete." + vbLf + "Activities Include: " + vbLf + act)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        txtAge.Text = ""
        txtName.Text = ""
        optSexMale.Checked = True
        optSexFemale.Checked = False
        chkActBiking.Checked = False
        chkActInLineShaking.Checked = False
        chkActRunning.Checked = False
        chkActSkiing.Checked = False
        chkActWalking.Checked = False
        chkActSwimming.Checked = False
        cboCity.SelectedItem = 0
        optLevelAdvance.Checked = False
        optLevelBeginner.Checked = True
        optLevelExtreme.Checked = False
        optLevelIntermediate.Checked = False
        act = ""
    End Sub
End Class

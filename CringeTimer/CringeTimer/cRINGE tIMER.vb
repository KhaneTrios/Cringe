Public Class frmMain
    Dim cringe As Integer
    Dim ouch As Integer
    Dim mult As Integer
    Dim multOn As Boolean

    Private Sub btnCringe_Click(sender As System.Object, e As System.EventArgs) Handles btnCringe.Click
        tmrCringe.Enabled = True
        tmrTen.Enabled = True
        tmrUpdate.Enabled = True

        If mult >= 1 Then
            mult = txtMult.Text
        End If

    End Sub

    Private Sub tmrCringe_Tick(sender As System.Object, e As System.EventArgs) Handles tmrCringe.Tick
        If tmrCringe.Interval = 1000 Then

            If multOn = False Then
                cringe = Val((cringe) + (1))
            End If

            If multOn = True Then
                cringe = Val((cringe) + (mult))
            End If
        End If
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        tmrCringe.Enabled = False
        cringe = 0
    End Sub

    Private Sub tmrUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUpdate.Tick
        If tmrUpdate.Interval <= 1 Then
            lblCringe.Text = cringe
            lblOuch.Text = ouch
        End If
    End Sub

    Private Sub tmrTen_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTen.Tick
        If tmrTen.Interval = 10000 Then
            ouch = Val((ouch) + (1))
            If ouch = 100 Then
                MessageBox.Show("You have died from Cancer.", "Killed", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCringe.Parent = picBack
        lblCringe.BackColor = Color.Transparent

        lblOuchText.Parent = picBack
        lblOuchText.BackColor = Color.Transparent

        lblOuch.Parent = picBack
        lblOuch.BackColor = Color.Transparent

        multOn = False
    End Sub

    Private Sub btnCool_Click(sender As System.Object, e As System.EventArgs) Handles btnCool.Click
        tmrCool.Enabled = True
    End Sub

    Private Sub tmrCool_Tick(sender As System.Object, e As System.EventArgs) Handles tmrCool.Tick
        If tmrCool.Interval = 1000 Then
            ouch = Val((ouch) - (1))

            If ouch <= 0 Then
                MessageBox.Show("You have beaten cancer.", "Remission", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ouch = 0
            End If
        End If
    End Sub

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        multOn = True
    End Sub
End Class

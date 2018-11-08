Public Class RubrosForm
    Dim operacion_ As String
    Dim indice_ As Integer
    Dim MiRubro As New RubroClass

    Public Property operacion() As String

        Get
            Return operacion_
        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set

    End Property

    Public Property indice() As Integer

        Get
            Return indice_
        End Get
        Set(ByVal value As Integer)
            indice_ = value
        End Set

    End Property

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        If operacion_ <> "Añadir" Then
            MiRubro.Id = CInt(idTextBox.Text)
        End If

        MiRubro.Descripcion = descTextBox.Text

        Select Case operacion_

            Case "Añadir"
                RubrosList.InsertarRubro(MiRubro)

            Case "Eliminar"
                RubrosList.EliminarRubro(MiRubro)

            Case "Modificar"
                RubrosList.ActualizarRubro(MiRubro)

                RubrosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()
    End Sub
End Class

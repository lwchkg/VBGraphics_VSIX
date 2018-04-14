Imports VBGraphics

Module $itemname$
    Sub Main()
        ' Create a graphics windows with resolution 600 x 400.
        Dim gw As New GraphicsWindow(600, 400)

        ' Draw something in the graphics window...
        gw.DrawLine(0, 0, 599, 399, Color.Red)
        gw.DrawText("Press any key to close...", 0, 370, Color.White, "Cambria", 16)

        ' Make the graphics window closable, and end the program when the window is closed.
        gw.EndProgramOnClose = True
        gw.CanClose = True

        ' Reads a key in the keyboard. Note: if the user closes the window, this statement will not
        ' finish execution.
        gw.ReadKey()

        ' It is a good habit to dispose the graphics window after use.
        gw.Dispose()
    End Sub
End Module

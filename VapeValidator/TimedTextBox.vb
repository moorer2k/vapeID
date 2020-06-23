Public Class TimedTextBox
	Inherits TextBox

	Private m_delayedTextChangedTimer As Timer

	Public Event DelayedTextChanged As EventHandler

	Public Sub New()
		MyBase.New()
		Me.DelayedTextChangedTimeout = 10 * 1000 ' 10 seconds
	End Sub

	Protected Overrides Sub Dispose(disposing As Boolean)
		If m_delayedTextChangedTimer IsNot Nothing Then
			m_delayedTextChangedTimer.Stop()
			If disposing Then
				m_delayedTextChangedTimer.Dispose()
			End If
		End If

		MyBase.Dispose(disposing)
	End Sub

	Public Property DelayedTextChangedTimeout() As Integer

	Protected Overridable Sub OnDelayedTextChanged(e As EventArgs)
		RaiseEvent DelayedTextChanged(Me, e)
	End Sub

	Protected Overrides Sub OnTextChanged(e As EventArgs)
		Me.InitializeDelayedTextChangedEvent()
		MyBase.OnTextChanged(e)
	End Sub

	Private Sub InitializeDelayedTextChangedEvent()
		If m_delayedTextChangedTimer IsNot Nothing Then
			m_delayedTextChangedTimer.Stop()
		End If

		If m_delayedTextChangedTimer Is Nothing OrElse m_delayedTextChangedTimer.Interval <> Me.DelayedTextChangedTimeout Then
			m_delayedTextChangedTimer = New Timer()
			AddHandler m_delayedTextChangedTimer.Tick, AddressOf HandleDelayedTextChangedTimerTick
			m_delayedTextChangedTimer.Interval = Me.DelayedTextChangedTimeout
		End If

		m_delayedTextChangedTimer.Start()
	End Sub

	Private Sub HandleDelayedTextChangedTimerTick(sender As Object, e As EventArgs)
		Dim timer As Timer = TryCast(sender, Timer)
		timer.Stop()

		Me.OnDelayedTextChanged(EventArgs.Empty)
	End Sub
End Class

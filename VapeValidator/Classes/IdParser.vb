Imports System.Globalization
Imports System.Text.RegularExpressions

Namespace Classes
    Public Class IdParser
        Private Property FirstNames As String() = {"DAC", "DBP", "DCT"}
        Private Property LastNames As String() = {"DAB", "DBO", "DCS"}
        Private Property FullName As String() = {"DAA"}
        Private Property Expiry As String() = {"DBA", "PAB"}
        Private Property Dobs As String() = {"DBB", "DBL"}
        Private Property Lic As String() = {"DAQ"}
        Private Property States As String() = {"DAJ"}
        Private Property AllFields = {"DAA", "DAB", "DAB", "DAC", "DAC", "DAD", "DAD", "DAE", "DAF", "DAG", "DAH", "DAI", "DAJ", "DAK", "DAL", "DAM", "DAN", "DAO", "DAP", "DAQ", "DAR", "DAS", "DAT", "DAU", "DAV", "DAW", "DAX", "DAY", "DAZ", "DBA", "DBB", "DBC", "DBD", "DBE", "DBF", "DBG", "DBH", "DBI", "DBJ", "DBK", "DBL", "DBM", "DBN", "DBO", "DBO", "DBP", "DBP", "DBQ", "DBQ", "DBR", "DBS", "DCA", "DCB", "DCD", "DCE", "DCF", "DCG", "DCH", "DCI", "DCJ", "DCK", "DCL", "DCM", "DCN", "DCO", "DCP", "DCQ", "DCR", "DCS", "DCS", "DCT", "DCT", "DCU", "DDA", "DDB", "DDC", "DDD", "DDE", "DDF", "DDG", "DDH", "DDI", "DDJ", "DDK", "DDL", "PAA", "PAB", "PAC", "PAD", "PAE", "PAF", "ZVA"}
        Public Function ParseData(data As String) As Identity

            Dim first As String = ""
            Dim last As String = ""
            Dim expiration As String = ""
            Dim age As Integer = 0
            Dim expired As Boolean
            Dim dateOfBirth As String = ""
            Dim id As String = ""
            Dim fulName As String() = Nothing
            Dim state As String = ""

            If data.Contains("|") Then data = data.Replace("|", "")
            Dim dataLines = Regex.Split(data.Trim(), "\n")

            'Sometimes the barcode data is concatenated. Let's do a quick hack to fix that.
            If dataLines.Length < 4 Then
                For Each field In AllFields
                    If data.Contains(field) Then
                        data = ReplaceFirst(data, field, vbCrLf & field)
                    End If
                Next
                dataLines = Regex.Split(data, "\n")
            End If

            Try

                If data.Contains("@") Then
                    For Each line In dataLines
                        If line.Length > 3 Then
                            If line.StartsWith("ANSI") OrElse line.Contains("AAMVA") Then
                                If line.Contains("DAA") Then
                                    Dim fff = Regex.Split(line, "DAA")
                                    line = "DAA" & fff(1)
                                End If
                            End If
                            Dim field = line.Substring(0, 3)

                            If line.Contains(Lic(0)) Then
                                id = Regex.Split(line, Lic(0))(1).ToString.Replace(" ", "").Trim() '.Substring(0, 8)
                            End If
                            Select Case True
                                Case MatchFieldName(LastNames, field)
                                    last = GetFieldValue(line)
                                Case MatchFieldName(FirstNames, field)
                                    Dim strFirst = GetFieldValue(line)
                                    If strFirst.Contains(",") Then
                                        Dim splitFirst = strFirst.Split(",")
                                        first = splitFirst(1) & " " & strFirst(0)
                                    Else
                                        first = strFirst
                                    End If

                                Case MatchFieldName(FullName, field)
                                    Dim fName = GetFieldValue(line)

                                    If fName.Contains(",") Then
                                        fulName = GetFieldValue(line).Split(",")
                                        first = fulName(1).Trim()
                                        last = fulName(0).Trim()
                                    ElseIf fName.Contains(" ") Then
                                        fulName = GetFieldValue(line).Split(" ")
                                        first = fulName(1).Trim()
                                        last = fulName(0).Trim()
                                    End If

                                Case MatchFieldName(Expiry, field)
                                    expiration = GetFieldValue(line)
                                    expired = IsExpired(expiration)
                                Case MatchFieldName(Dobs, field)
                                    dateOfBirth = GetFieldValue(line)
                                    age = CalcAgeByDob(dateOfBirth)
                                Case MatchFieldName(States, field)
                                    state = GetFieldValue(line)

                            End Select
                        End If
                    Next

                    Dim underAge = age < My.Settings.MinAgeOfPurchase

                    Return New Identity(first, last, dateOfBirth, expiration, id, age, expired, underAge, state)

                End If

                Return Nothing

            Catch ex As Exception
                Throw New Exception(ex.InnerException.ToString())
            End Try

        End Function
        Private Shared Function ReplaceFirst(text As String, search As String, replace As String) As String
            Dim pos As Integer = text.IndexOf(search, StringComparison.Ordinal)
            If pos < 0 Then
                Return text
            End If
            Return text.Substring(0, pos) + replace & text.Substring(pos + search.Length)
        End Function

        Private Shared Function MatchFieldName(names As String(), field As String) As Boolean
            Return names.Any(Function(x) x = field)
        End Function
        Private Shared Function GetFieldValue(line As String) As String
            Return line.Substring(3, line.Length - 3).Trim()
        End Function

        'Public Function ParseRawAnsi(timeText As String) As Identity

        '    Dim first As String = ""
        '    Dim last As String = ""
        '    Dim expiration As String = "" '8 digits
        '    Dim age As Integer = 0
        '    Dim expired As Boolean
        '    Dim dateOfBirth As String = ""
        '    Dim id As String = ""
        '    Dim fulName As String = ""
        '    'timeText = timeText.Replace(" ", "")

        '    For Each field In AllFields
        '        If timeText.Contains(field) Then
        '            timeText = timeText.Replace(field, vbCrLf & field)
        '        End If
        '    Next
        '    'Debug.WriteLine(timeText)

        '    Try

        '        For Each lName In LastNames
        '            If timeText.Contains(lName) Then
        '                Dim flast = Regex.Split(timeText, lName)(1).ToString
        '                last = Regex.Split(flast, vbNewLine)(0).Trim
        '            End If
        '        Next

        '        For Each fName In FirstNames
        '            If timeText.Contains(fName) Then
        '                Dim ffirst = Regex.Split(timeText, fName)(1).ToString
        '                first = Regex.Split(ffirst, vbNewLine)(0).Trim
        '            End If
        '        Next


        '        For Each exp In Expiry
        '            If timeText.Contains(exp) Then
        '                Dim test = Regex.Split(timeText, exp)
        '                Debug.WriteLine(test)
        '                expiration = Regex.Split(timeText, exp)(1).ToString.Substring(0, 8)
        '                expired = IsExpired(expiration)
        '            End If
        '        Next

        '        For Each dob In Dobs
        '            If timeText.Contains(dob) Then
        '                dateOfBirth = Regex.Split(timeText, dob)(1).ToString.Substring(0, 8)
        '                age = CalcAgeByDob(dateOfBirth)
        '            End If
        '        Next

        '        Dim underAge = age < My.Settings.MinAgeOfPurchase

        '        If timeText.Contains(FullName(0)) Then
        '            fulName = Regex.Split(timeText, FullName(0))(1)

        '            If fulName IsNot Nothing Then
        '                Dim nameParts = fulName.Split(",")
        '                first = nameParts(1).Split(vbCrLf)(0)
        '                last = nameParts(0)
        '            End If

        '        End If

        '        If timeText.Contains(Lic(0)) Then
        '            id = Regex.Split(timeText, Lic(0))(1).ToString.Replace(" ", "").Substring(0, 9).Split(vbCrLf)(0) 'sometimes IDs have spaces in them. Get rid of those first.
        '        End If

        '        Return New Identity(first, last, dateOfBirth, expiration, id, age, expired, underAge)

        '    Catch ex As Exception

        '    End Try

        '    Return Nothing

        'End Function

        Private Shared Function IsExpired(intDate As String) As Boolean
            Dim idDate = Date.ParseExact(intDate, GetDateFormat(intDate), Nothing)
            If (Date.Now > idDate) Then
                Return True
            End If
            Return False
        End Function

        Private Shared Function GetDateFormat(strDateTime As String) As String

            Dim formats() As String = {"Mdyyyy", "MMddyyyy", "dMyyyy", "ddMMyyyy", "yyyyMd", "yyyyMMdd", "yyyyddMM"}

            Dim dateValue As Date = Nothing

            Return formats.FirstOrDefault(Function(dateStringFormat) Date.TryParseExact(strDateTime, dateStringFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, dateValue))

        End Function

        Private Shared Function CalcAgeByDob(intDate As String) As Integer

            Try
                Dim birthdate = Date.ParseExact(intDate, GetDateFormat(intDate), Nothing)
                Dim today = Date.Today
                Dim age = today.Year - birthdate.Year

                If birthdate.Date > today.AddYears(-age) Then
                    age -= 1
                End If

                Return age

            Catch ex As Exception

            End Try

            Return Nothing

        End Function

    End Class
End Namespace
Module Module1
    'Use records(or equivalent) in the design of solutions to simple problems
    Structure Town

        'Town properties
        Dim townName As String
        Dim county As String
        Dim population As Integer
        Dim area As Double
        'without using constructor below create a town dim t as Town
        ' t.townName = "Leeds"
        ' t.County = "West Yorkshire"
        ' t.population = 230
        ' t.area = 13.23

        'Constructor - Used when createing new town
        Sub New(tName As String, tCounty As String, tPop As Integer, tArea As Double)
            townName = tName
            county = tCounty
            population = tPop
            area = tArea
        End Sub
        ' in main program use dim t as new town("Leeds","West Yorkshire",230,13.23)

    End Structure
    Sub Main()

        ' Use arrays(or equivalent) in the design of solutions to simple problems
        Dim names() As String = {"Bob", "Betty", "Steve"}
        Dim namesAgain As String() = {"Bob", "Betty", "Steve"}
        Dim scores(3) As Integer ' array upper bound (last index) is 3
        scores(0) = 12
        scores(1) = 30
        scores(2) = 11
        scores(3) = 19
        ' scores(4) = 77 ' Outside bounds of array

        Dim scores2 As Double() = New Double() {3.13, 22.23, 15.88, 17}
        Console.WriteLine(names.Length) ' length Of names
        Console.WriteLine(scores(0)) ' first value In scores
        Console.WriteLine(scores2(scores2.Length - 1)) ' last value In scores 2

        ' Two dimensional array
        Dim tableData(,) As Integer = {{1, 2, 3, 4, 5, 6, 7}, {10, 11, 12, 13, 14, 15, 16}}
        Console.WriteLine(tableData(0, 0)) ' 1
        Console.WriteLine(tableData(1, 0)) ' 10
        Console.WriteLine(tableData(tableData.GetLength(0) - 1, tableData.GetLength(1) - 1)) ' 16

        Dim UserPWD(3, 1) As String
        UserPWD(0, 0) = "Bob"
        UserPWD(0, 1) = "letmein"
        UserPWD(1, 0) = "Ben"
        UserPWD(1, 1) = "12345"


        Console.WriteLine(UserPWD.GetLength(0)) ' first dimension
        Console.WriteLine(UserPWD.GetLength(1)) ' second dimension

        ' Looping through arrays
        For Each number As Integer In scores ' goes through each item in the array
            Console.WriteLine(number)
        Next

        For i = 0 To scores.Length - 1 ' uses index referencing in the array
            Console.WriteLine(scores(i))
        Next

        For Each unPw As String In UserPWD ' for each works on 2D array, does sequence (0,0), (0,1), ..., (0,n), (1,0), (1,1), ...., (n,n) 
            Console.WriteLine(unPw)
        Next

        'Using structures (records)
        Dim heckmondwike As New Town("Hecky", "W Yorks", 350, 120.5)
        Console.WriteLine(heckmondwike.area)
        heckmondwike.population += 300

        Dim batley As Town
        batley.townName = "Batley"
        batley.population = 100
        batley.county = "W Yorks"
        batley.area = 66.4
        Console.WriteLine(batley.population)

    End Sub


End Module

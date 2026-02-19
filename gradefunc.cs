using System;

/* ************** functions *************** */
    string GetGrade(double marks){

        if (marks >= 90) return "Grade A";
        else if (marks >= 80) return "Grade B";
        else if (marks >= 70) return "Grade C";
        else if (marks < 40) return "Failed";
        else return "Passed";
    }

    bool IsPassed (double marks) => marks >= 40;
    
    // for double array 
    double CalculateAverage(double[] marks)
    {
        double sum = 0;
        foreach (double m in marks)
            sum += m;
        return sum/marks.Length;
    }

    void CalculatePassedFailed (double[] marks, out int passed, out int failed){
        passed = 0;
        failed = 0;

        foreach (double m in marks){
            if (IsPassed(m)) passed++;
            else  failed++;
        }
    }


    // for dictionary
    double CalcAvgDict(Dictionary<string, double> studentMarks)
    {
        double sum = 0;
        foreach (double m in studentMarks.Values)
         sum += m;
        return sum / studentMarks.Count;
    }



/* ************** flow *************** */

//for array

     double[] marksArray = { 95.5, 82.3, 76.8, 39.5, 55.0 };

    //print grades
    foreach (double marks in marksArray){
        Console.WriteLine($"Marks: {marks} - {GetGrade(marks)}");
    }

    //Count passed and failed
    CalculatePassedFailed(marksArray, out int passedCount, out int failedCount);

    //Print Percentages
    double passedPercentage = (double)passedCount / marksArray.Length * 100; 
    double failedPercentage = (double)failedCount / marksArray.Length * 100; 
    Console.WriteLine($"\nPassed: {passedCount} ({passedPercentage:F2}%)");
    Console.WriteLine($"\nFailed: {failedCount} ({failedPercentage:F2}%)");

    //Print avg marks
    double average = CalculateAverage(marksArray);
    Console.WriteLine($"Average Marks: {average:F2}");



    //for dictionary, Dictionary<string, double>

    Dictionary<string, double> studentMarks = new Dictionary<string, double>()
    {
        { "StudentA", 95.5 },
        { "StudentB", 82.3 },
        { "StudentC", 76.8 },
        { "StudentD", 39.5 },
        { "StudentE", 55.0 }
    };



using System.Collections.Generic;

namespace UnitTestProject1
{
    public class CocaCola
    {
        // 1. Here are two methods. The first wil make the unit test
        // fail. And the second will make it pass

        //public List<int> GetCocaCola()
        //{
        //    var numbers = new List<int> { 0, 0 };
        //    return numbers;
        //} 

        //public List<int> Get CocaCola()
        //{
        //    var numbers = new List<int>[1, 2];
        //    return numbers;
        //}

        // 2. The GetCocaCola method now takes and argument as the roof and 
        // the second test passes.

        //public List<string> GetCocaCola (int roof)
        //{
        //    var numbers = new List<string>();

        //    for (var i = 1; i <= roof; i++)
        //    {
        //        if (i % 3 == 0)
        //        {
        //            numbers.Add("Coca");
        //        }
        //        else
        //        {
        //            numbers.Add(i.ToString());
        //        }
        //    }
        //    return numbers;
        //}

        // 3. Here is the GetCocaCola method so that test 3 would pass:

        //public List<string> GetFizzBuzz(int roof)
        //{
        //    var numbers = new List<string>();

        //    for (var i = 1; i <= roof; i++)
        //    {
        //        if (i % 3 == 0)
        //        {
        //            numbers.Add("Coca");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            numbers.Add("Cola");
        //        }
        //        else
        //        {
        //            numbers.Add(i.ToString());
        //        }
        //    }
        //    return numbers;
        //}

        // Here is how we refactored the code after the first three test so it would be easier
        // to read. After we refactored our code we ran the test again and they all passed.

        //public List<string> GetCocaCola(int roof)
        //{
        //    var sequence = new List<string>();

        //    for (var i = 1; i <= roof; i++)
        //    {
        //        sequence.Add(GetNextCocaCola(i));
        //    }
        //    return sequence;
        //}

        //public string GetNextCocaCola(int position)
        //{
        //    if (position % 3 == 0)
        //    {
        //        return ("Coca");
        //    }
        //    if (position % 5 == 0)
        //    {
        //        return "Cola";
        //    } 

        //}

        public List<string> GetCocaCola(int roof)
        {
            var sequence = new List<string>();

            for (var i = 1; i <= roof; i++)
            {
                sequence.Add(GetNextCocaCola(i));
            }
            return sequence;
        }

        // 4. Here is what our GetNextCocaCola method looked like when test failed. Under this section
        // is the rewritten code so that test 4 passes. 

        //public string GetNextCocaCola(int position)
        //{
        //    if (position % 3 == 0)
        //    {
        //        return ("Coca");
        //    }
        //    if (position % 5 == 0)
        //    {
        //        return "Cola";
        //    } 

        public string GetNextCocaCola(int position)
        {
            var nextCocaCola = string.Empty;
            var isCocaOrCola = false;

            if (position % 3 == 0)
            {
                nextCocaCola = "Coca";
                isCocaOrCola = true;
            }
            else if (position % 5 == 0)
            {
                nextCocaCola = "Cola";
                isCocaOrCola = true;
            }
            else
            {
                nextCocaCola = position.ToString();
            }

            if (isCocaOrCola && position % 3 == 0 && position % 5 == 0)
            {
                nextCocaCola = "CocaCola";
            }
            return nextCocaCola;
        }

        public void WriteCocaCola()
        {

        }

    }
}
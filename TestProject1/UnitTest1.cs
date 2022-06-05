using Microsoft.VisualStudio.TestTools.UnitTesting;

using MoodAnalyzer;



namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        public void GivenSad_ReturnSad()
        {
            HappyorSad happySad = new HappyorSad("iam in sad mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("SAD", Result);
        }

        [TestMethod]
        public void GivenHappy_ReturnHappy()
        {
            HappyorSad happySad = new HappyorSad("iam in happy mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", Result);
        }


        /*[TestMethod]
        public void GivenNull_ReturnHappy()
        {
            HappySad happySad = new HappySad(null);
            string result = happySad.AnalysingMood();
            Assert.AreEqual("HAPPY", result);
        }*/


        [TestMethod]
        public void GivenNull_RetunCustomException()
        {
            try
            {
                HappyorSad happySad = new HappyorSad(" ");
                string result = happySad.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("message should not be null", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmpty_RetunCustomException()
        {
            try
            {
                HappyorSad happySad = new HappyorSad("");
                string result = happySad.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("message should not be empty", ex.Message);
            }
        }





        [TestMethod]
        public void GivingClassNameRight_ReturnsObject()
        {
            HappyorSad happySad = new HappyorSad(" ");
            MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
            object MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            happySad.Equals(MyObj);
        }


        [TestMethod]
        public void GivingClassNameWrong_RetunCustomException()
        {
            try
            {
                HappyorSad happySad = new HappyorSad(" ");
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
                var MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class Name is Wrong", ex.Message);
            }
        }


        [TestMethod]
        public void GivingConstructorWrong_RetunCustomException()
        {
            try
            {
                HappyorSad happySad = new HappyorSad(" ");
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySa");
                var MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Constructor Name is Wrong", ex.Message);
            }
        }




        [TestMethod]
        public void GivingMessageRight_ReturnsObject()
        {
            HappyorSad happySad = new HappyorSad("I Am Happy");
            MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
            object MyObj = MoodAnalyserFactory.InvokeMethod(factory, "I Am Happy");
            happySad.Equals(MyObj);
        }


        [TestMethod]
        public void GivingMessageWrong_RetunCustomException()
        {
            try
            {
                HappyorSad happySad = new HappyorSad("I Am in any Mood");
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
                var MyObj = MoodAnalyserFactory.InvokeMethod(factory, "I am in any Mood");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class Name is Wrong", ex.Message);
            }
        }





        [TestMethod]
        public void GivingFieldName_Wrong_RetunCustomException()
        {
            string Expected = "wrong field name";
            try
            {
                var result = MoodAnalyzerReflector.SetField("I Am Happy", "WrongField");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }

        [TestMethod]
        public void GiveingMessage_Wrong_RetunCustomException(MoodAnalyzerReflector reflector)
        {
            string Expected = "Message Should not be Null";
            try
            {
                object? result = reflector.SetField(null, "Message");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }

    }
}   

    

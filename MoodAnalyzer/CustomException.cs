using System.Runtime.Serialization;

namespace MoodAnalyzer
{
    [Serializable]
    public class CustomException : Exception
    {
       
        
            public enum ExceptionType
            {
                NULL_MESSAGE, EMPTY_MESSAGE,
                CLASS_NOT_FOUND,
                CONSTRUCTOR_NOT_FOUND,
                WRONG_FIELD,
                WRONG_MESSAGE
            }
            public ExceptionType Type;

            public CustomException(ExceptionType type, string message) : base(message)
            {
                Type = type;
            }
    }  
    
}
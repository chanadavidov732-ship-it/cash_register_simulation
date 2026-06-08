
namespace BO
{
    //add another exceptions
    [Serializable]
    public class Dont_Found_Id_Exception : Exception
    {
        public Dont_Found_Id_Exception(string? message) : base(message) { }

        public Dont_Found_Id_Exception(string? message, Exception? innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class Already_Exist_Id_Exception : Exception
    {
        public Already_Exist_Id_Exception(string? message) : base(message) { }

        public Already_Exist_Id_Exception(string? message, Exception? innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BL_Dont_Faund_EntitysId_Exception : Exception
    {
        public BL_Dont_Faund_EntitysId_Exception(string? message) : base(message) { }

        public BL_Dont_Faund_EntitysId_Exception(string? message, Exception? innerException) : base(message, innerException) { }
    }


    [Serializable]
    public class BL_Entitys_Already_Exist_Exception : Exception
    {
        public BL_Entitys_Already_Exist_Exception(string? message) : base(message) { }

        public BL_Entitys_Already_Exist_Exception(string? message, Exception? innerException) : base(message, innerException) { }
    }

}


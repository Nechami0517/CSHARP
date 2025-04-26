namespace BO
{
    [Serializable]
    public class BlIDoesNotExist : Exception
    {
        public BlIDoesNotExist()
        {
        }

        public BlIDoesNotExist(string error)
            : base(error)
        {
        }

        public BlIDoesNotExist(string error, Exception innerException)
            : base(error, innerException)
        {
        }
    }
    
    [Serializable]
    public class BlIdExist : Exception
    {
        public BlIdExist()
        {
        }

        public BlIdExist(string error)
            : base(error)
        {
        }

        public BlIdExist(string error, Exception innerException)
            : base(error, innerException)
        {
        }
    }

    [Serializable]
    public class BlSystemException : Exception
    {
        public BlSystemException()
        {
        }

        public BlSystemException(string error)
            : base(error)
        {
        }

        public BlSystemException(string error, Exception innerException)
            : base(error, innerException)
        {
        }
    }
}

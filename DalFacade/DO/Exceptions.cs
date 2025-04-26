namespace DO;


[Serializable]
public class DalIDoesNotExist : Exception
{
    
    public DalIDoesNotExist(String error) => throw new Exception(error);


}

[Serializable]
public class DalIdExist : Exception

{
    public DalIdExist(String error) => throw new Exception(error);
  
}

[Serializable]
public class DalSystemException : Exception

{
    public DalSystemException(String error) => throw new Exception(error);

}
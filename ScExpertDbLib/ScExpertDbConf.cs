namespace ScExpertDbLib
{
    public class ScExpertDbConf
    {
        public string ConnectionString { get; set; }

        public ScExpertDbConf()
        {

        }

        public ScExpertDbConf(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool ConnectToScExpert()
        {
            return false;
        }
    }
}
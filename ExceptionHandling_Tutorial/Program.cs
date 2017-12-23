using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////// TRY CATCH BLOCK FOR HANDLING EXCEPTIONS //////////

            ///// NOTE: Arrange exceptions from most specific to most generic ////
            /////       Since the generic exceptions do not allow more detailed info

            try
            {
                //internally the compiler creates a "finally{}" block under the hood
                //which will call the dispose method of the streamReader
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    //opening stream and reading
                    var content = streamReader.ReadToEnd();
                }
                throw new Exception("Ooops");
            }
            catch (Exception ex)
            {
                //// rethrowing the error
                //throw;
                Console.WriteLine("Sorry, unexpected error occured");
            }
            ////executed no matter what
            ////used when resources are not handled by CLR
            //finally { }

            /////////////////////////// SECOND EXAMPLE ///////////////////////
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

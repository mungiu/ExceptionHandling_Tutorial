using System;
using System.Collections.Generic;

namespace ExceptionHandling_Tutorial
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //access youtube web service
                //read data
                //create list of video objects
                throw new Exception("Ooops");

            }
            //catching all exceptions
            catch (Exception ex)
            {
                //Log exceptions

                //NOTE: passing the exception details to code that can read it
                //But displaying to end user customer exception message
                throw new YouTubeException("Could not fetch videos from youtube", ex);
            }

            return new List<Video>();
        }
    }
}

using System;
using System.Net;

namespace Redmine.Tests
{
    public class TestWebRequest : WebRequest, IWebRequestCreate
    {
        private static TestWebRequest Next;

        private TestWebRequest()
        {
        }
        
        new public virtual void Create(Uri uri) { } // Used for mock expectation

        public static IWebRequestCreate GetCreator(TestWebRequest next)
        {
            Next = next;

            return new TestWebRequest();
        }

        WebRequest IWebRequestCreate.Create(Uri uri)
        {
            Next.Create(uri);

            return Next;
        }
    }
}

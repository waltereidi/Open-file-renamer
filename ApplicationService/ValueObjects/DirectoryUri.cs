using static System.Web.HttpUtility;
using System.Text;
using System.Text.Encodings.Web;

namespace ApplicationService.ValueObjects
{
    public class DirectoryUri
    {
        private readonly DirectoryInfo _dir;
        public string Value { get; private set; }
        private DirectoryUri(DirectoryInfo value)
        {
            _dir = value;
            EnsureIsValid();
            SetUriEncodedPath();
        }
        
        private void EnsureIsValid()
        {
            if (!_dir.Exists)
                throw new DirectoryNotFoundException(); 

        }
        public static string FromEncodedUri(string encodedUri)
            => UrlDecode(encodedUri, Encoding.UTF8);
        public void SetUriEncodedPath()
            => Value = UrlEncoder.Default.Encode(_dir.FullName);

        public static implicit operator string(DirectoryUri uri)
            => uri.Value;

        public static explicit operator DirectoryUri(string uri)
            => new DirectoryUri(new (uri));

    }
}

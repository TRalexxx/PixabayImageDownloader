using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Web;

namespace PixabayDownloader
{
    public partial class PixabayImageDownloader : Form
    {
        private string _requestUrl = "https://pixabay.com/api/?key=34119107-36198c444b18f56d819681a4c&q=yellow+flowers&image_type=all";
        private string _savePath = "H:\\Pixabay";

        public PixabayImageDownloader()
        {
            InitializeComponent();
        }

        private string SearchWordsTorequestString(string searchWords)
        {
            char[] splitters = new char[] { ' ', ',', '.', '/', '_', '\\', '+', '-' };

            string[] words = searchWords.Split(splitters);

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(word);
                sb.Append('+');
            }

            sb.Length = sb.Length - 1;
            return sb.ToString();
        }

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _savePath = dlg.SelectedPath;
                TBSaveFolder.Text = _savePath;
            }

        }

        private string GetSearchRequestString()
        {
            string res = $"https://pixabay.com/api/?key=34119107-36198c444b18f56d819681a4c&q={SearchWordsTorequestString(TBSearchWords.Text)}" +
                $"&per_page={NUDImagesNumber.Value}&image_type=all";

            return res;
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {

            WebClient web = new WebClient();
            Uri uri = new Uri(GetSearchRequestString());


            string s = web.DownloadString(uri);

            HitsCollection requestResultCollection = JsonSerializer.Deserialize<HitsCollection>(s);

            try
            {
                foreach (var item in requestResultCollection.hits)
                {
                    web.DownloadFile(new Uri(item.largeImageURL), $"{_savePath}\\{item.id}.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something goes wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Done!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
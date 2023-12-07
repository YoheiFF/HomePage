using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace HomePage.Controllers
{
    public class ImageController : Controller
    {
        public ActionResult GetImage()
        {
            // ここで画像データを読み込んだり生成したりするロジックを追加

            // 例: 画像のパスを指定してファイルを読み込む
            var imagePath = "C:\\Users\\yohei\\OneDrive\\画像\\ベイマックス2.jpg";
            byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);

            return File(imageBytes, "image/jpeg"); // 画像データを返す
        }

        //    private static List<string> imagePaths = GetImagePaths(); // 画像ファイルのパスを取得

        //    public ActionResult GetImage(int index)
        //    {
        //        // 指定されたインデックスの画像を取得
        //        string imagePath = imagePaths.ElementAtOrDefault(index);

        //        if (imagePath != null)
        //        {
        //            byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
        //            return File(imageBytes, "image/jpeg");
        //        }

        //        // 画像が存在しない場合の処理（例えばデフォルトの画像など）
        //        return Content("Image not found");
        //    }

        //    // フォルダ内の画像ファイルのパスを取得するメソッド
        //    private static List<string> GetImagePaths()
        //    {
        //        string folderPath = "C:\\Users\\yohei\\OneDrive\\画像\\"; // フォルダのパスを指定

        //        if (Directory.Exists(folderPath))
        //        {
        //            return Directory.GetFiles(folderPath, "*.jpg").ToList();
        //        }

        //        return new List<string>();
        //    }
        //}
    }
}
// 画像の切り替え用の関数
function changeImage() {
    // 現在表示されている画像のソースを取得
    var currentImageSrc = document.getElementById("image").src;

    // 画像のファイル名を取得
    var currentImageName = currentImageSrc.substring(currentImageSrc.lastIndexOf("/") + 1);

    // 画像の番号を取得
    var currentImageNumber = parseInt(currentImageName.replace(/[^0-9]/g, ''));

    // 次の画像の番号を計算
    var nextImageNumber = (currentImageNumber % 3) + 1;

    // 次の画像のソースを設定
    document.getElementById("image").src = "Img/" + nextImageNumber + ".jpg";
}

// 一定の間隔で画像を切り替える（3秒ごと）
setInterval(changeImage, 3000);
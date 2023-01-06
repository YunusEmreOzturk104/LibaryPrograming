<!DOCTYPE html>
<script runat="server">

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs)

    End Sub
</script>





<html lang="tr">
<head>
<title>Login V1</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">

<link rel="icon" type="image/png" href="Login_v1/images/icons/favicon.ico" />

<link rel="stylesheet" type="text/css" href="Login_v1/vendor/bootstrap/css/bootstrap.min.css">

<link rel="stylesheet" type="text/css" href="Login_v1/fonts/font-awesome-4.7.0/css/font-awesome.min.css">

<link rel="stylesheet" type="text/css" href="Login_v1/vendor/animate/animate.css">

<link rel="stylesheet" type="text/css" href="Login_v1/vendor/css-hamburgers/hamburgers.min.css">

<link rel="stylesheet" type="text/css" href="Login_v1/vendor/select2/select2.min.css">

<link rel="stylesheet" type="text/css" href="Login_v1/css/util.css">
<link rel="stylesheet" type="text/css" href="Login_v1/css/main.css">

<meta name="robots" content="noindex, follow">
<script nonce="72c93b48-12b8-4c51-b5f0-8bc999fc0cf6">(function (w, d) { !function (eK, eL, eM, eN) { eK.zarazData = eK.zarazData || {}; eK.zarazData.executed = []; eK.zaraz = { deferred: [], listeners: [] }; eK.zaraz.q = []; eK.zaraz._f = function (eO) { return function () { var eP = Array.prototype.slice.call(arguments); eK.zaraz.q.push({ m: eO, a: eP }) } }; for (const eQ of ["track", "set", "debug"]) eK.zaraz[eQ] = eK.zaraz._f(eQ); eK.zaraz.init = () => { var eR = eL.getElementsByTagName(eN)[0], eS = eL.createElement(eN), eT = eL.getElementsByTagName("title")[0]; eT && (eK.zarazData.t = eL.getElementsByTagName("title")[0].text); eK.zarazData.x = Math.random(); eK.zarazData.w = eK.screen.width; eK.zarazData.h = eK.screen.height; eK.zarazData.j = eK.innerHeight; eK.zarazData.e = eK.innerWidth; eK.zarazData.l = eK.location.href; eK.zarazData.r = eL.referrer; eK.zarazData.k = eK.screen.colorDepth; eK.zarazData.n = eL.characterSet; eK.zarazData.o = (new Date).getTimezoneOffset(); if (eK.dataLayer) for (const eX of Object.entries(Object.entries(dataLayer).reduce(((eY, eZ) => ({ ...eY[1], ...eZ[1] }))))) zaraz.set(eX[0], eX[1], { scope: "page" }); eK.zarazData.q = []; for (; eK.zaraz.q.length;) { const e_ = eK.zaraz.q.shift(); eK.zarazData.q.push(e_) } eS.defer = !0; for (const fa of [localStorage, sessionStorage]) Object.keys(fa || {}).filter((fc => fc.startsWith("_zaraz_"))).forEach((fb => { try { eK.zarazData["z_" + fb.slice(7)] = JSON.parse(fa.getItem(fb)) } catch { eK.zarazData["z_" + fb.slice(7)] = fa.getItem(fb) } })); eS.referrerPolicy = "origin"; eS.src = "/cdn-cgi/zaraz/s.js?z=" + btoa(encodeURIComponent(JSON.stringify(eK.zarazData))); eR.parentNode.insertBefore(eS, eR) };["complete", "interactive"].includes(eL.readyState) ? zaraz.init() : eK.addEventListener("DOMContentLoaded", zaraz.init) }(w, d, 0, "script"); })(window, document);</script></head>
<body>
<div class="limiter">
<div class="container-login100">
<div class="wrap-login100">
<div class="login100-pic js-tilt" data-tilt>
<img src="Login_v1/images/img-01.png" alt="IMG">
</div>
<form class="login100-form validate-form" runat="server">
<span class="login100-form-title">
Kullanıcı Girişi
</span>
<div class="wrap-input100 validate-input" data-validate="Kullanıcı Adı Gerekli">
<asp:TextBox ID="txtUserName" CssClass="input100" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
<span class="focus-input100"></span>
<span class="symbol-input100">
<i class="fa fa-envelope" aria-hidden="true"></i>
</span>
</div>
<div class="wrap-input100 validate-input" data-validate="Sifre Gerekli">
<asp:TextBox ID="txtSifre" CssClass="input100" runat="server" placeholder="Şifre"></asp:TextBox>
<span class="focus-input100"></span>
<span class="symbol-input100">
<i class="fa fa-lock" aria-hidden="true"></i>
</span>
</div>
<div class="container-login100-form-btn">
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" CssClass="login100-form-btn" />
</div>
<div class="text-center p-t-12">
<span class="txt1">
Kullanıcı Adı ve Şifre
</span>
<a class="txt2" href="#">
Unuttum
</a>
</div>
    <p>  <asp:Label ID="Label1" runat="server" Text=""></asp:Label> </p>
<div class="text-center p-t-136">
<a class="txt2" href="#">
Yeni Hesap Oluştur
<i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
</a>
</div>
</form>
</div>
</div>
</div>

<script src="Login_v1/vendor/jquery/jquery-3.2.1.min.js"></script>

<script src="Login_v1/vendor/bootstrap/js/popper.js"></script>
<script src="Login_v1/vendor/bootstrap/js/bootstrap.min.js"></script>

<script src="Login_v1/vendor/select2/select2.min.js"></script>

<script src="Login_v1/vendor/tilt/tilt.jquery.min.js"></script>
<script>
    $('.js-tilt').tilt({
        scale: 1.1
    })
</script>

<script async src="https://www.googletagmanager.com/gtag/js?id=UA-23581568-13"></script>
<script>
    window.dataLayer = window.dataLayer || [];
    function gtag() { dataLayer.push(arguments); }
    gtag('js', new Date());

    gtag('config', 'UA-23581568-13');
</script>

<script src="Login_v1/js/main.js"></script>
<script defer src="https://static.cloudflareinsights.com/beacon.min.js/vaafb692b2aea4879b33c060e79fe94621666317369993" integrity="sha512-0ahDYl866UMhKuYcW078ScMalXqtFJggm7TmlUtp0UlD4eQk0Ixfnm5ykXKvGJNFjLMoortdseTfsRT8oCfgGA==" data-cf-beacon='{"rayId":"784c9937aa6650f9","token":"cd0b4b3a733644fc843ef0b185f98241","version":"2022.11.3","si":100}' crossorigin="anonymous"></script>
</body>
</html>

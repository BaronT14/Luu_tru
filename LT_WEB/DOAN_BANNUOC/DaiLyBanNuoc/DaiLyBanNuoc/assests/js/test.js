var registerLayout = `
<div class="auth-form">
            <div class="auth-form__container">
                <div class="auth-form__header">
                    <h3 class="auth-form__heading">Đăng ký</h3>
                    <span class="auth-form__switch--btn">Đăng nhập</span>
                </div>
                <div class="auth-form__form">
                    <div class="auth-form__group">
                        <input type="Text" class="auth-form__input" placeholder="Nhập họ tên" name="HoTen">
                    </div>
                    <div class="auth-form__group">
                        <select class="form-select" id="gioitinh" name="GioiTinh">
                            <option selected>--Chọn giới tính--</option>
                            <option value="Nam">Nam</option>
                            <option value="Nữ">Nữ</option>
                            <option value="Khác">Khác</option>
                        </select>
                    </div>
                    <div class="auth-form__group">
                        <input type="Text" class="auth-form__input" placeholder="Nhập số điện thoại" name="DienThoai">
                    </div>
                    <div class="auth-form__group">
                        <input type="Text" class="auth-form__input" placeholder="Nhập email" name="Email">
                    </div>
                    <div class="auth-form__group">
                        <input type="Text" class="auth-form__input" placeholder="Nhập địa chỉ" name="DiaChi">
                    </div>
                    <div class="auth-form__group">
                        <input type="password" class="auth-form__input" placeholder="Nhập mật khẩu" name="MatKhau">
                    </div>
                    <div class="auth-form__group">
                        <input type="password" class="auth-form__input" placeholder="Nhập lại mật khẩu" name="MatKhau2">
                    </div>
                </div>
                <div class="auth-form__aside">
                    <p class="auth-form__policy-text">
                        Bằng việc đăng kí, bạn đã đồng ý với Đại lí bán nước về <br>
                        <a href="" class="auth-form__text-link">Điều khoản dịch vụ</a> &
                        <a href="" class="auth-form__text-link">Chính sách bảo mật</a>
                    </p>
                </div>
                <div class="auth-form__controls">
                    <button class="btn auth-form__controls-back btn--normal">TRỞ LẠI</button>
                    <button type="submit" class="btn btn--primary">ĐĂNG KÝ</button>
                </div>
            </div>

            <div class="auth-form__socials">
                <a href="" class="auth-form__socials--facebook btn btn--size-s btn--with-icon">
                    <i class="auth-form__socials-icon fa-brands fa-square-facebook"></i>
                    <span class="auth-form__socials-label">Kết nối với Facebook</span>
                </a>
                <a href="" class="auth-form__socials--google btn btn--size-s btn--with-icon">
                    <svg class="auth-form__socials-icon" xmlns="http://www.w3.org/2000/svg" x="0px" y="0px" width="24" height="24" viewBox="0 0 48 48">
                        <path fill="#FFC107" d="M43.611,20.083H42V20H24v8h11.303c-1.649,4.657-6.08,8-11.303,8c-6.627,0-12-5.373-12-12c0-6.627,5.373-12,12-12c3.059,0,5.842,1.154,7.961,3.039l5.657-5.657C34.046,6.053,29.268,4,24,4C12.955,4,4,12.955,4,24c0,11.045,8.955,20,20,20c11.045,0,20-8.955,20-20C44,22.659,43.862,21.35,43.611,20.083z"></path>
                        <path fill="#FF3D00" d="M6.306,14.691l6.571,4.819C14.655,15.108,18.961,12,24,12c3.059,0,5.842,1.154,7.961,3.039l5.657-5.657C34.046,6.053,29.268,4,24,4C16.318,4,9.656,8.337,6.306,14.691z"></path>
                        <path fill="#4CAF50" d="M24,44c5.166,0,9.86-1.977,13.409-5.192l-6.19-5.238C29.211,35.091,26.715,36,24,36c-5.202,0-9.619-3.317-11.283-7.946l-6.522,5.025C9.505,39.556,16.227,44,24,44z"></path>
                        <path fill="#1976D2" d="M43.611,20.083H42V20H24v8h11.303c-0.792,2.237-2.231,4.166-4.087,5.571c0.001-0.001,0.002-0.001,0.003-0.002l6.19,5.238C36.971,39.205,44,34,44,24C44,22.659,43.862,21.35,43.611,20.083z"></path>
                    </svg>
                    <span class="auth-form__socials-label">Kết nối với Google</span>
                </a>
            </div>
        </div>`

var loginLayout = `
<div class="auth-form">
    <div class="auth-form__container">
        <div class="auth-form__header">
            <h3 class="auth-form__heading">Đăng nhập</h3>
            <span class="auth-form__switch--btn">Đăng ký</span>
        </div>
        <div class="auth-form__form">
            <div class="auth-form__group">
                <input type="Text" class="auth-form__input" placeholder="Nhập email">
            </div>
            <div class="auth-form__group">
                <input type="password" class="auth-form__input" placeholder="Nhập mật khẩu">
            </div>
        </div>
        <div class="auth-form__aside">
            <div class="auth-form__help">
                <a href="" class="auth-form__help-link auth-form__help-forfot">Quên mật khẩu</a>
                <span class="auth-form__help-separate"></span>
                <a href="" class="auth-form__help-link">Cần trợ giúp?</a>
            </div>
        </div>
        <div class="auth-form__controls">
            <button class="btn auth-form__controls-back btn--normal">TRỞ LẠI</button>
            <button class="btn btn--primary">ĐĂNG NHẬP</button>
        </div>
    </div>
    
    <div class="auth-form__socials">
        <a href="" class="auth-form__socials--facebook btn btn--size-s btn--with-icon">
            <i class="auth-form__socials-icon fa-brands fa-square-facebook"></i>
            <span class="auth-form__socials-label">Kết nối với Facebook</span>
        </a>
        <a href="" class="auth-form__socials--google btn btn--size-s btn--with-icon">
            <svg class="auth-form__socials-icon" xmlns="http://www.w3.org/2000/svg" x="0px" y="0px" width="24" height="24" viewBox="0 0 48 48">
                <path fill="#FFC107" d="M43.611,20.083H42V20H24v8h11.303c-1.649,4.657-6.08,8-11.303,8c-6.627,0-12-5.373-12-12c0-6.627,5.373-12,12-12c3.059,0,5.842,1.154,7.961,3.039l5.657-5.657C34.046,6.053,29.268,4,24,4C12.955,4,4,12.955,4,24c0,11.045,8.955,20,20,20c11.045,0,20-8.955,20-20C44,22.659,43.862,21.35,43.611,20.083z"></path><path fill="#FF3D00" d="M6.306,14.691l6.571,4.819C14.655,15.108,18.961,12,24,12c3.059,0,5.842,1.154,7.961,3.039l5.657-5.657C34.046,6.053,29.268,4,24,4C16.318,4,9.656,8.337,6.306,14.691z"></path><path fill="#4CAF50" d="M24,44c5.166,0,9.86-1.977,13.409-5.192l-6.19-5.238C29.211,35.091,26.715,36,24,36c-5.202,0-9.619-3.317-11.283-7.946l-6.522,5.025C9.505,39.556,16.227,44,24,44z"></path><path fill="#1976D2" d="M43.611,20.083H42V20H24v8h11.303c-0.792,2.237-2.231,4.166-4.087,5.571c0.001-0.001,0.002-0.001,0.003-0.002l6.19,5.238C36.971,39.205,44,34,44,24C44,22.659,43.862,21.35,43.611,20.083z"></path>
            </svg>
            <span class="auth-form__socials-label">Kết nối với Google</span>
        </a>
    </div>
</div>`

var test = document.querySelectorAll('.header__navbar-item');

test.forEach((item, index) => {
    item.onclick = function(){
        var result = item.innerHTML;
        openAuth(result);
    }
})

function closeAuth(){
    var arr = []
    arr.push(document.querySelector('.modal__overlay'));
    arr.push(document.querySelector('.auth-form__controls-back'));
    console.log(arr)
    arr.forEach((item, index) => {
        item.onclick = () => {
            document.querySelector('.modal').style.display = "none";
        }
    })
}

function openAuth(result){
    if(result === "Đăng ký"){
        var modal = document.querySelector('.modal');
        modal.style.display = "flex";
        document.querySelector('.modal__body').innerHTML = registerLayout;
    }
    if(result === "Đăng nhập"){
        var modal = document.querySelector('.modal');
        modal.style.display = "flex";
        document.querySelector('.modal__body').innerHTML = loginLayout;
    }
    closeAuth();
    convertLogin_Register();
}

function convertLogin_Register(){
    var switch_btn = document.querySelector('.auth-form__switch--btn');
    switch_btn.onclick = () => {
        openAuth(switch_btn.innerHTML)
    }
}

function link_History(){
    var ulItem = document.querySelectorAll('.header__search-history-item');
    console.log(ulItem);
    ulItem.forEach((item, index) => {
        item.onclick = function(){
            console.log(item);
        }
    })
}

link_History();

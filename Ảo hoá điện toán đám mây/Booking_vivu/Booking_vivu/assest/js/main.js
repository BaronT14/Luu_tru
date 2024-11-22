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
            window.location.href = '/Home/TrangChu';
        }
    })
}

function openAuth(result){
    if (result === "Đăng ký") {
        window.location.href = '/Home/Register';
    }
    if (result === "Đăng nhập") {
        window.location.href = '/Home/Login';
    }
}

function convertLogin_Register(){
    var switch_btn = document.querySelector('.auth-form__switch--btn');
    switch_btn.onclick = () => {
        openAuth(switch_btn.innerHTML)
    }
}

closeAuth()
convertLogin_Register()

//form google
function sendMess(){
    const fieldName = document.getElementById('name');
    const fieldPhone = document.getElementById('phone');
    const fieldMess = document.getElementById('mess');

    const data = {
        nameData: fieldName.value,
        phoneData: fieldPhone.value,
        messData: fieldMess.value,
    };

    // check field required
    if (data.nameData && data.phoneData && data.messData) {
        submitForm(data);
    }
};

async function submitForm(data) {
    const formURL = 'https://docs.google.com/forms/d/e/1FAIpQLSfeT7clMw2xunno1j0f4YhEv3rSBkRr2oDHyCJOqZKb8DGNHA/formResponse';
    const fieldName = 'entry.1221173733';
    const fieldPhone = 'entry.1569456273';
    const fieldMess = 'entry.1135298773';
    const formData = new FormData();

    formData.append(fieldName, data.nameData);
    formData.append(fieldPhone, data.phoneData);
    formData.append(fieldMess, data.messData);

    fetch(formURL, {
        method: 'POST',
        mode: 'no-cors',
        body: formData
    })
    .then(response => {
        console.log('Form submitted');
        document.getElementById('contact__form-btn').classList.add('contact__form-btn-sent')
    })
    .catch(error => {
        console.error('Error:', error);
    });
}

function layDiaDiem() {
    var show_diadiem = document.getElementById('search-place');
    var ds_diadiem = document.querySelectorAll('#ds-tour');

    ds_diadiem.forEach((item, index) => {
        item.onclick = function () {
            show_diadiem.innerText = item.innerHTML;
        }
    })
}

function layGia() {
    var show_gia = document.getElementById('show-price');
    var ds_gia = document.querySelectorAll('#price-list');

    ds_gia.forEach((item, index) => {
        item.onclick = function () {
            show_gia.innerText = item.innerHTML;
        }
    })
}

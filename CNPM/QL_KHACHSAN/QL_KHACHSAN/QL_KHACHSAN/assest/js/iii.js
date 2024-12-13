function toast({ title = "", message = "", type = "", duration = 3000 }) {
  const main = document.getElementById("toast");
  if (main) {
    const toast = document.createElement("div");

    const autoRemove = setTimeout(function () {
      main.removeChild(toast);
    }, 4300);

    toast.onclick = function (e) {
      if (e.target.closest(".toast__close")) {
        main.removeChild(toast);
        clearTimeout(autoRemove);
      }
    };
    const icons = {
      success: "fa fa-check-circle",
      warning: "fas fa-info-circle",
      danger: "fas fa-times-circle",
    };
    const icon = icons[type];
    toast.classList.add("toast", `toast--${type}`);
    toast.style.animation = `slideInLeft ease 0.3s, fadeOut linear 1s 3s forwards`;
    toast.innerHTML = `
        <div class="toast__icon">
          <i class="${icon}" aria-hidden="true"></i>
        </div>
        <div class="toast__body">
          <h3 class="toast__title">${title}</h3>
          <p class="toast__msg">${message}</p>
        </div>
        <button class="toast__close">
          <i class="fa fa-times" aria-hidden="true"></i>
        </button>
    `;
    main.appendChild(toast);
  }
}

function showSuccess(message = "Đăng nhập thành công") {
  toast({
    title: "Thành công",
    message: message,
    type: "success",
  });
}

function showWarning(message = "Cảnh báo") {
  toast({
    title: "Cảnh báo",
    message: message,
    type: "warning",
  });
}

function showDanger(message = "Sai mật khẩu hoặc tên đăng nhập") {
  toast({
    title: "Thất bại",
    message: message,
    type: "danger",
  });
}



document.addEventListener("DOMContentLoaded", function () {
    const checkAll = document.getElementById("check-all");
    if (!checkAll) return;

    checkAll.addEventListener("change", function () {
        const checkboxes = document.querySelectorAll(".row-check");
        checkboxes.forEach(cb => cb.checked = this.checked);
        checkAll.indeterminate = false;
        
    });

  
    document.addEventListener("change", function (e) {
        if (!e.target.classList.contains("row-check")) return;

        const checkboxes = document.querySelectorAll(".row-check");
        const checkedCount = [...checkboxes].filter(cb => cb.checked).length;

        if (checkedCount === 0) {
            checkAll.checked = false;
            checkAll.indeterminate = false;
        } else if (checkedCount === checkboxes.length) {
            checkAll.checked = true;
            checkAll.indeterminate = false;
        } else {
            checkAll.checked = false;
            checkAll.indeterminate = true;
        }
    });
});
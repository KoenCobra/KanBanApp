function ToggleDropdown() {
    document.querySelector(".edit-delete-modal").classList.toggle("show");
}

function CloseDropDown(event) {
    if (!event.target.matches('.drop-btn')) {
        var dropdowns = document.querySelectorAll(".edit-delete-modal");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}
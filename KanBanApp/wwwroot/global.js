function ToggleDropdown() {
    document.querySelector(".edit-delete-modal").classList.toggle("show");
}

function CloseDropDown(event) {
    if (!event.target.matches('.drop-btn')) {
        var dropdown = document.querySelector(".edit-delete-modal");
        if (dropdown.classList.contains('show')) {
            dropdown.classList.remove('show');
        }
    }
}

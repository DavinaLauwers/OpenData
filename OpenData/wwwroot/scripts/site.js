window.showConfirmDelete = (id) => {
    $('#' + id).modal('show');
};

window.hideConfirmDelete = (id) => {
    $('#' + id).modal('hide');
};


window.goToDetails = (id) => {
    $('#' + id).modal('show');
};
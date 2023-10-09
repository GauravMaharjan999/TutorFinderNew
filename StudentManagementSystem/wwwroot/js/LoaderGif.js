function onAjaxBegin() {
    
    $("#main-div").removeClass("ShowLoader").addClass("ShowLoader");
}

function onAjaxComplete() {
    
    $("#main-div").removeClass("ShowLoader").addClass("HideLoader");
}
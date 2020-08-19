// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function displayTitles() {
    var participantRoles = document.getElementsByClassName("participant-role");

    for (var i = 0; i < participantRoles.length; i++) {
        if (participantRoles[i].innerHTML == "PresidingLeader")
        {
            participantRoles[i].innerHTML = "Presiding";
        }
        else if (participantRoles[i].innerHTML == "ConductingLeader") {
            participantRoles[i].innerHTML = "Conducting";
        }
        else if (participantRoles[i].innerHTML == "OpeningPrayer") {
            participantRoles[i].innerHTML = "Opening Prayer";
        }
        else if (participantRoles[i].innerHTML == "ClosingPrayer") {
            participantRoles[i].innerHTML = "Closing Prayer";
        }
    }
}
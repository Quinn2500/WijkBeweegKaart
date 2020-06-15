
var mymap = L.map('mapid').setView([51.47358, 5.453167], 13);
var OpenStreetMap_Mapnik = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
    {

        maxZoom: 19,
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(mymap);

var marker = L.marker();

function onMapClick(e) {
    marker
        .setLatLng(e.latlng)
        .bindPopup("You clicked the map at " + e.latlng.toString())
        .addTo(mymap);
    document.getElementsByName("StartLocationLat")[0].value = e.latlng.lat;
    document.getElementsByName("StartLocationLong")[0].value = e.latlng.lng;
}

mymap.on('click', onMapClick);


$(document).ready(function () {

    $('#EndDate').datepicker({
        format: 'dd/mm/yyyy',
        uiLibrary: 'bootstrap4',
        startDate: '+14d'
    });

    $("body").on("change",
        "select",
        function (e) {
            console.log($(this));
            if (this.id.includes("Type")) {
                var parentDiv = $(this).parent();
                parentDiv.children('.question').remove();
                var str = this.id;
                var indexOfPage = str.indexOf("t_");
                var indexOfQeustions = str.indexOf("s_");
                var pageNumber = str.charAt(indexOfPage + 2);
                var questionNumber = str.charAt(indexOfQeustions + 2);
                switch (parseInt(this.value)) {
                    case 0:
                        $(parentDiv).append('<div class="question">' +
                            '<select data-val="true" data-val-required="The GeoType field is required." id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__GeoType" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].GeoType">' +
                            ' <option selected="selected" value="0">Marker</option>' +
                            ' <option value="1">Lijn</option>' +
                            '<option value="2">Vlak</option>' +
                            '</select>' +
                            '</div>');
                        break;
                    case 1:
                        $(parentDiv).append('<div class="question">' +
                            '<div class=mcWrapper>' +
                            '<label>Laat meerdere antwoorden toe:</label>' +
                            '<input data-val="true" data-val-required="The AllowMultipleAnswers field is required." id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__AllowMultipleAnswers" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].AllowMultipleAnswers" type="checkbox" value="true"/>' +
                            '<div class="MCOption">' +
                            '<label>Antwoord:</label> <input id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__Options_0__Answer" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].Options[0].Answer" type="text" value="" />' +
                            '<label>Eventuele beschrijving:</label> <input id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__Options_0__Description" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].Options[0].Description" type="text" value="" />' +
                            '<label for="OptionCounter" style="display: none;">0</label>' +
                            '<a href="" class="removeMCOption">Verwijderen</a>' +
                            '</div> ' +
                            '</div>' +
                            '<div class="addMCOptions"><a href="" class="addMCOption" btn btn-info">+</a><br><br></div>' +
                            '</div>');
                        break;
                    case 3:
                        $(parentDiv).append('<div class="question">' +
                            '<input id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__SliderMaxText" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].SliderMaxText" type="text" value="" />' +
                            '<input id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__SliderMinText" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].SliderMinText" type="text" value="" />' +
                            '<input data-val="true" data-val-required="The SliderScaleVal field is required." id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__SliderScaleVal" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].SliderScaleVal" type="number" />' +
                            '</div>');
                        break;
                    case 4:
                        $(parentDiv).append('<div class="question">' +
                            '<input data-val="true" data-val-required="The MaxValue field is required." id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__MaxValue" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].MaxValue" type="number" />' +
                            '<input data-val="true" data-val-required="The MinValue field is required." id="PagesList_' +
                            pageNumber +
                            '__Questions_' +
                            questionNumber +
                            '__MinValue" name="PagesList[' +
                            pageNumber +
                            '].Questions[' +
                            questionNumber +
                            '].MinValue" type="number"/>' +
                            '</div>');
                        break;

                }
            }
        });

    //Pagina
    var MaxInputsPage = 10;
    var InputsWrapper = $("#InputsWrapper");
    var AddButtonPage = $("#AddMoreFileBox");
    var x = InputsWrapper.length;
    $(AddButtonPage).click(function (e) {
        e.preventDefault();
        var currentPageCount = $('.pageDiv').length;
        if (x <= MaxInputsPage) {
            $(InputsWrapper).append('<div class="pageDiv">' +
                '<h3>Pagina ' +
                currentPageCount +
                '</h3>' +
                '<input id="PagesList_' + currentPageCount + '__Title" name="PagesList[' + currentPageCount + '].Title" type="text" value="" /><span class="field-validation-valid" data-valmsg-for="PagesList[' +
                currentPageCount +
                '].Title" data-valmsg-replace="true"></span>' +
                '<input id="PagesList_' +
                currentPageCount +
                '__Description" name="PagesList[' +
                currentPageCount +
                '].Description" type="text" value="" /><span class="field-validation-valid" data-valmsg-for="PagesList[' +
                currentPageCount +
                '].Description" data-valmsg-replace="true"></span>' +
                '<label for="PageCounter" style="display: none;">' +
                currentPageCount +
                '</label>' +
                '<div class="QuestionWrapper">' +
                '</div>' +
                '<div class="addQuestion"> <a href="#" class="addQuestionButton btn btn-info">Voeg Vraag Toe</a><br><br></div> ' +
                '<a href="" class="removeclass btn btn-danger">Pagina verwijderen</a>' +
                '</div>');
            x++;

            $("#AddMoreFileId").show();

            $('AddMoreFileBox').html("Add field");

            if (x == MaxInputsPage) {
                $("#AddMoreFileId").hide();
            }
        }
        return false;
    });

    $(".removeclass").click( function (e) {
            e.preventDefault();
            if (x > 1) {
                $(this).parent('div').remove(); //remove text box
                x--; //decrement textbox
                var i;
                var pages = $('.pageDiv').toArray();
                var counters = $('.pageDiv label[for=PageCounter]').toArray();
                for (i = 0; i < pages.length; i++) {
                    var children = pages[i].children;
                    for (j = 0; j < children.length; j++) {
                        var child = children[j];
                        switch (child.tagName) {
                            case "H3":
                                child.innerHTML = "Pagina " + i;
                                break;
                            case "INPUT":
                                child.id = child.id.replace("PagesList_" + counters[i].innerHTML, "PagesList_" + i);
                                child.name = child.name.replace("PagesList[" + counters[i].innerHTML + "]",
                                    "PagesList[" + i + "]");
                                break;
                            case "LABEL":
                                child.innerHTML = i;
                                break;
                            default:
                        }
                    }

                };
                $("#AddMoreFileId").show();
                // Adds the "add" link again when a field is removed.
                $('AddMoreFileBox').html("Add field");
            }
            return false;
        });

    $(".addQuestionButton").click( function (e) {
            e.stopPropagation();
            e.stopImmediatePropagation();
            e.preventDefault();
            var pageNumber = $(this).parent().parent().children("label")[0].innerHTML;
            var questionWrapper = $(this).parent().parent().children(".QuestionWrapper");
            var currentQuestionCount = $(questionWrapper).children(".questionDiv").length;
            $(questionWrapper).append('<div class="questionDiv">' +
                '<h3>Vraag ' +
                currentQuestionCount +
                '</h3>' +
                '<input id="PagesList_' +
                pageNumber +
                '__Questions_' +
                currentQuestionCount +
                '__Title" name="PagesList[' +
                pageNumber +
                '].Questions[' +
                currentQuestionCount +
                '].Title" type="text" value="" />' +
                '<input id="PagesList_' +
                pageNumber +
                '__Questions_' +
                currentQuestionCount +
                '__Description" name="PagesList[' +
                pageNumber +
                '].Questions[' +
                currentQuestionCount +
                '].Description" type="text" value="" />' +
                '<select data-val="true" data-val-required="The Type field is required." id="PagesList_' +
                pageNumber +
                '__Questions_' +
                currentQuestionCount +
                '__Type" name="PagesList[0].Questions[' +
                currentQuestionCount +
                '].Type">' +
                '<option selected="selected" value="0">GeoVraag</option><option value="1">MeerkeuzeVraag</option>' +
                '<option value="2">OpenVraag</option>' +
                '<option value="3">SliderVraag</option><option value="4">NummerVraag</option></select>                                       ' +
                '<select data-val="true" data-val-required="The Category field is required." id="PagesList_' +
                pageNumber +
                '__Questions_' +
                currentQuestionCount +
                '__Category" name="PagesList[0].Questions[' +
                currentQuestionCount +
                '].Category">' +
                '<option selected="selected" value="0">Profiel</option><option value="1">Locatie</option><option value="2">Gezondheid</option></select>' +
                '<label for="QuestionCounter" style="display: none;">' +
                currentQuestionCount +
                '</label>' +
                '<a href="" class="removeQuestionClass btn btn-danger">Vraag verwijderen</a>' +
                '</div>');
    });

    $(".removeQuestionClass").click( function (e) {
            e.preventDefault();
            var questionsWrapper = $(this).parent().parent();
            var i;
            var j;
            var q;
            if (questionsWrapper.children().length > 1) {

                $(this).parent('div').remove();
                var questions = questionsWrapper.children();
                console.log(questions);
                for (q = 0; q < questions.length; q++) {
                    var children = questions[q].children;
                    var oldNumber = children[5].innerHTML;
                    for (j = 0; j < children.length; j++) {
                        var child = children[j];
                        switch (child.tagName) {
                            case "H3":
                                child.innerHTML = "Vraag " + q;
                                break;
                            case "INPUT":
                                child.id = child.id.replace("Questions_" + oldNumber, "Questions_" + q);
                                child.name = child.name.replace("Questions[" + oldNumber + "]", "Questions[" + q + "]");
                                break;
                            case "SELECT":
                                child.id = child.id.replace("Questions_" + oldNumber, "Questions_" + q);
                                child.name = child.name.replace("Questions[" + oldNumber + "]", "Questions[" + q + "]");
                                break;
                            case "LABEL":
                                child.innerHTML = q;
                                break;
                            default:
                        }
                    }
                }
            }
            return false;
        });
});


$(".addMCOption").click(function (e) {
        e.preventDefault();
        var wrapper = $(this).parent().parent().children()[0];
        var numberOfOptions = $(wrapper).children(".MCOption").length;

        var pageNumber = $(this).parent().parent().parent().parent().parent().children("label")[0].innerHTML;
        var questionWrapper = $(this).parent().parent().parent().parent().parent().children(".QuestionWrapper");
        var currentQuestionCount = $(questionWrapper).children(".questionDiv").length - 1;

        console.log(wrapper);
        console.log(currentQuestionCount);

        $(wrapper).append(
            '<div class="MCOption">' +
            '<label>Antwoord:</label> <input id="PagesList_' + pageNumber + '__Questions_' + currentQuestionCount + '__Options_' + numberOfOptions + '__Answer" name="PagesList[' + pageNumber + '].Questions[' +
            currentQuestionCount +
            '].Options[' +
            numberOfOptions +
            '].Answer" type="text" value="" />' +
            '<label>Eventuele beschrijving:</label> <input id="PagesList_' +
            pageNumber +
            '__Questions_' +
            currentQuestionCount +
            '__Options_' +
            numberOfOptions +
            '__Description" name="PagesList[' +
            pageNumber +
            '].Questions[' +
            currentQuestionCount +
            '].Options[' +
            numberOfOptions +
            '].Description" type="text" value="" />' +
            '<label for="OptionCounter" style="display: none;">' +
            numberOfOptions +
            '</label>' +
            '<a href="" class="removeMCOption btn btn-danger">Verwijderen</a>' +
            '</div> ');
        return false;
    });

$(".removeMCOption").click(function (e) {
        e.preventDefault();
        var wrapper = $(this).parent().parent().parent().children()[0];
        $(this).parent('div').remove();
        var options = $(wrapper).children(".MCOption");
        var i;
        var q;
        for (i = 0; i < options.length; i++) {
            var children = options[i].children;
            var oldNumber = children[4].innerHTML;
            children[4].innerHTML = i;
            for (q = 0; q < children.length; q++) {
                var child = children[q];
                switch (child.tagName) {
                    case "INPUT":
                        child.id = child.id.replace("Options_" + oldNumber, "Options_" + i);
                        child.name = child.name.replace("Options[" + oldNumber + "]", "PagesList[" + i + "]");
                        break;
                    default:
                        break;
                }
            }
        }
        return false;
    });

$(window).on('load', function () {

    String.prototype.replaceAt = function (index, char) {
        var a = this.split("");
        a[index] = char;
        return a.join("");
    }

    $(document).ready(function () {

        $('#EndDate').datepicker({ dateFormat: "dd-mm-yy", minDate: -0 });

        $('.dropdown-toggle').dropdown();


        function appendToDiv(parentDiv, url, pageNumber, questionNumber, optionNumber) {
            url = url.replace("pageNumberJS", pageNumber);
            url = url.replace("questionNumberJS", questionNumber);
            url = url.replace("optionNumberJS", optionNumber);
            url = url.replace(/&amp;/g, '&');
            $.ajax({
                type: "GET",
                url: url,
                success: function (text) {
                    $(parentDiv).append(text);
                }
            });
        }

        $("body").on("change",
            "select",
            function (e) {
                if (this.id.includes("Type")) {
                    var parentDiv = $(this).parent();
                    parentDiv.children('.question').empty();
                    console.log($(this));
                    var str = this.id;
                    var indexOfPage = str.indexOf("t_");
                    var indexOfQeustions = str.indexOf("s_");
                    var pageNumber = str.charAt(indexOfPage + 2);
                    var questionNumber = str.charAt(indexOfQeustions + 2);
                    var url = "";
                    switch (parseInt(this.value)) {
                        case 0:
                            if (parentDiv.parent().parent().children("label")[0].innerHTML == "true") {
                                url =
                                    '@Url.Action("GeoQuestion","Create", new { pageId = "pageNumberJS", questionId = "questionNumberJS", firstGeoQuestionInPage = true})';
                                parentDiv.parent().parent().children("label")[0].innerHTML = false;
                            } else {
                                url =
                                    '@Url.Action("GeoQuestion","Create", new { pageId = "pageNumberJS", questionId = "questionNumberJS", firstGeoQuestionInPage = false})';
                            }
                            appendToDiv(parentDiv.children('.question'), url, pageNumber, questionNumber);
                            break;
                        case 1:
                            url =
                                '@Url.Action("MultipleChoiceQuestion","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
                            appendToDiv(parentDiv.children('.question'), url, pageNumber, questionNumber);
                            break;
                        case 3:
                            url =
                                '@Url.Action("SliderQuestion","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
                            appendToDiv(parentDiv.children('.question'), url, pageNumber, questionNumber);
                            break;
                        case 4:
                            url =
                                '@Url.Action("NumberQuestion","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
                            appendToDiv(parentDiv.children('.question'), url, pageNumber, questionNumber);
                            break;
                    }

                }

            });


        var profileQuestionsUsed = false;
        var nngbQuestionsUsed = false;
        var motivationQuestionsUsed = false;


        //Pagina
        var MaxInputsPage = 10;
        var InputsWrapper = $("#InputsWrapper");
        var AddButtonPage = $("#AddMoreFileBox");
        var x = InputsWrapper.length;
        $(AddButtonPage).click(function (e) {
            e.preventDefault();
            var currentPageCount = $('.pageDiv').length;
            if (x <= MaxInputsPage) {
                var url = '@Url.Action("PageView","Create", new {pageId = "pageNumberJS", questionId = "0"})';
                url = url.replace("pageNumberJS", currentPageCount);
                url = url.replace(/&amp;/g, '&');
                $.ajax({
                    type: "GET",
                    url: url,
                    success: function (text) {

                        if (profileQuestionsUsed) {
                            text = $(text).find('.addProfileQuestionButton').remove().end();
                        }

                        if (nngbQuestionsUsed) {
                            text = $(text).find('.addNNGBQuestionButton').remove().end();
                        }

                        if (motivationQuestionsUsed) {
                            text = $(text).find('.addMotivationQuestionButton').remove().end();
                        }

                        $(InputsWrapper).append(text);
                    }
                });


                x++;
                $("#AddMoreFileId").show();
                $('AddMoreFileBox').html("Add field");
                if (x == MaxInputsPage) {
                    $("#AddMoreFileId").hide();
                }
            }
            return false;
        });

        $("body").on("click", ".addProfileQuestionButton", function (e) {
            e.preventDefault();
            var str = $(this).parent().attr('id');
            var indexOfPage = str.indexOf("_Page");
            var pageNumber = str.charAt(indexOfPage + 5);
            var questionWrapper = $(this).parent().parent().parent().parent().children(".QuestionWrapper");
            var currentQuestionCount = $(questionWrapper).children(".questionDiv").length;
            var url = '@Url.Action("ProfileQuestions","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
            appendToDiv(questionWrapper, url, pageNumber, currentQuestionCount);
            profileQuestionsUsed = true;
            $(".addProfileQuestionButton").hide();
        });

        $("body").on("click", ".addNNGBQuestionButton", function (e) {
            e.preventDefault();
            var str = $(this).parent().attr('id');
            var indexOfPage = str.indexOf("_Page");
            var pageNumber = str.charAt(indexOfPage + 5);
            var questionWrapper = $(this).parent().parent().parent().parent().children(".QuestionWrapper");
            var currentQuestionCount = $(questionWrapper).children(".questionDiv").length;
            var url = '@Url.Action("NngbQuestions","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
            appendToDiv(questionWrapper, url, pageNumber, currentQuestionCount);
            nngbQuestionsUsed = true;
            $(".addNNGBQuestionButton").hide();
        });

        $("body").on("click", ".addMotivationQuestionButton", function (e) {
            e.preventDefault();
            var str = $(this).parent().attr('id');
            var indexOfPage = str.indexOf("_Page");
            var pageNumber = str.charAt(indexOfPage + 5);
            var questionWrapper = $(this).parent().parent().parent().parent().children(".QuestionWrapper");
            var currentQuestionCount = $(questionWrapper).children(".questionDiv").length;
            var url = '@Url.Action("MotivationQuestions","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
            appendToDiv(questionWrapper, url, pageNumber, currentQuestionCount);
            motivationQuestionsUsed = true;
            $(".addMotivationQuestionButton").hide();
        });

        $("body").on("click",
            ".removeclass",
            function (e) {
                e.preventDefault();
                if (x > 0) {
                    $(this).parent().parent().parent().parent('div').remove();
                    x--;
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
                }
                return false;
            });

        $("body").on("click", ".addQuestionButton", function (e) {
            e.stopPropagation();
            e.stopImmediatePropagation();
            e.preventDefault();
            var pageNumber = $(this).parent().parent().parent().children().length - 1;
            var questionWrapper = $(this).parent().parent().children(".QuestionWrapper");
            var currentQuestionCount = $(questionWrapper).children(".questionDiv").length;
            var url = '@Url.Action("QuestionView", "Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS"})';
            appendToDiv(questionWrapper, url, pageNumber, currentQuestionCount);
        });

        $("body").on("click",
            ".removeQuestionClass",
            function (e) {
                e.preventDefault();
                var questionsWrapper = $(this).parent().parent().parent().parent();
                var j;
                var q;

                var typePreMadeQuestion = $(this).attr("class").split(/\s+/)[0];
                $("div." + typePreMadeQuestion).remove();

                switch (typePreMadeQuestion) {
                    case "profileQuestion":
                        profileQuestionsUsed = false;
                        $(".addProfileQuestionButton").show();
                        break;
                    case "nngbQuestion":
                        nngbQuestionsUsed = false;
                        $(".addNNGBQuestionButton").show();
                        break;
                    case "motivationQuestion":
                        motivationQuestionsUsed = false;
                        $(".addMotivationQuestionButton").show();
                        break;
                }

                if (questionsWrapper.children().length > 1) {
                    $(this).parent().parent().parent('div').remove();
                    var questions = questionsWrapper.children();
                    for (q = 0; q < questions.length; q++) {
                        var questionNumber = q;
                        var questionDiv = $(questions[q]);
                        $(questionDiv).children("H3").text("Vraag " + (q + 1));

                        $(questionDiv).children("INPUT").each(function (index) {
                            var textId = $(this).attr("id");
                            var nameText = $(this).attr("name");
                            $(this).attr("id", textId.replaceAt(textId.indexOf("Questions_") + 10, questionNumber));
                            $(this).attr("name", nameText.replaceAt(nameText.indexOf("Questions[") + 10, questionNumber));
                        });

                        $(questionDiv).children("SELECT").each(function (index) {
                            var textId = $(this).attr("id");
                            var nameText = $(this).attr("name");
                            $(this).attr("id", textId.replaceAt(textId.indexOf("Questions_") + 10, questionNumber));
                            $(this).attr("name", nameText.replaceAt(nameText.indexOf("Questions[") + 10, questionNumber));

                        });

                        if ($(questionDiv).children(".mcWrapper").length > 0) {
                            $(questionDiv).children(".mcWrapper").children("INPUT").each(function (index) {
                                var textId = $(this).attr("id");
                                var nameText = $(this).attr("name");
                                $(this).attr("id", textId.replaceAt(textId.indexOf("Questions_") + 10, questionNumber));
                                $(this).attr("name", nameText.replaceAt(nameText.indexOf("Questions[") + 10, questionNumber));
                            });

                            $(questionDiv).children(".mcWrapper").children(".MCOption").each(function (index) {
                                var option = $(this);
                                $(option).children("INPUT").each(function (index) {
                                    var textId = $(this).attr("id");
                                    var nameText = $(this).attr("name");
                                    $(this).attr("id", textId.replaceAt(textId.indexOf("Questions_") + 10, questionNumber));
                                    $(this).attr("name", nameText.replaceAt(nameText.indexOf("Questions[") + 10, questionNumber));
                                });
                            });
                        }
                    }
                }

                return false;
            });


        $("body").on("click",
            ".addMCOption",
            function (e) {
                e.preventDefault();
                var wrapper = $(this).parent().parent().children()[0];
                var numberOfOptions = $(wrapper).children(".MCOption").length;
                var pageNumber = $("#InputsWrapper").children(".pageDiv").length - 1;
                var currentQuestionCount = parseInt($(this).parent().parent().parent().parent().children("label")[0].innerHTML);

                var url = '@Url.Action("MultipleChoiceOption","Create", new {pageId = "pageNumberJS", questionId = "questionNumberJS", optionId="optionNumberJS"})';
                appendToDiv(wrapper, url, pageNumber, currentQuestionCount, numberOfOptions);
                return false;
            });

        $("body").on("click",
            ".removeMCOption",
            function (e) {
                e.preventDefault();
                var wrapper = $(this).parent().parent().parent().parent();
                console.log(wrapper);
                $(this).parent().parent().parent('div').remove();
                var options = $(wrapper).children(".MCOption");
                var i;
                var q;
                for (i = 0; i < options.length; i++) {
                    var children = options[i].children;
                    console.log(children);
                    var oldNumber = children[5].innerHTML;
                    children[5].innerHTML = i;
                    for (q = 0; q < children.length; q++) {
                        var child = children[q];
                        switch (child.tagName) {
                            case "H4":
                                child.innerHTML = "Optie " + (q + 1);
                                break;
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

    });

});
//Hotel Autocomplete
var HotelAutoComplete = function () {
    var TagHotel = "TagDestinationHotel";
    $.widget("custom.catcomplete", $.ui.autocomplete, {
        _create: function () {
            this._super();
            this.widget().menu("option", "items", "> :not(.ui-autocomplete-category)");
        },
        _renderMenu: function (ul, items) {
            var that = this,
                currentCategory = "";
            var cont = 0;
            $.each(items, function (index, item) {
                var li;
                if (item.category !== currentCategory) {
                    switch (item.category) {
                        case "City":
                            ul.append("<li class='ui-autocomplete-category'><span class='icon-location'></span>Ciudad</li>");
                            break;
                        case "Zone":
                            ul.append("<li class='ui-autocomplete-category'><span class='icon-location'></span>Zona</li>");
                            break;
                        case "Hotel":
                            ul.append("<li class='ui-autocomplete-category'><span class='icon-hotel'></span>Hotel</li>");
                    }
                    cont = 0;
                    currentCategory = item.category;
                }
                if (cont < 5) {
                    li = that._renderItemData(ul, item);
                    if (item.category) {
                        li.attr("aria-label", item.category + " : " + item.label);
                    }
                }
                cont = cont + 1;
            });
        },
        _renderItem: function (ul, item) {
            var newText = String(item.value).replace(
                new RegExp(this.term, "gi"),
                "<span class='ui-state-highlight'>$&</span>");

            return $("<li id='" + TagHotel + "'></li>")
                .data("item.autocomplete", item)
                .append("<a id='" + TagHotel + "'>" + newText + "</a>")
                .appendTo(ul);
        }
    });
    $(".destination-autocomplete").catcomplete({
        source: function (request, response) {
            var itemnamecodes = new Array();
            Pace.ignore(function () {
                var data = {
                    destinations: [
                         { destinationId: 1, destinationName:'Cancun', destinationUrl: 'Cancun', category: 'Ciudades'}
                        ,{ destinationId: 2, destinationName:'Riviera Maya', destinationUrl: 'riviera-maya', category: 'Ciudades'}
                        ,{ destinationId: 3, destinationName:'Cozumel', destinationUrl: 'cozumel', category: 'Ciudades'}
                        ,{ destinationId: 4, destinationName:'Puerto Vallarta', destinationUrl: 'puerto-vallarta', category: 'Ciudades'}
                    ],
                    hotels: [
                         { hotelId: 1, hotelName:'Hotel Posadas', hotelUrl: 'hotel-posadas', destinationId: 1, destinationName:'Cancun', destinationUrl: 'Cancun', zoneName: 'Playa', countryName: 'México', category: 'Hotel'}
                        ,{ hotelId: 5, hotelName:'Hotel Riviera Maya', hotelUrl: 'hotel-riviera-maya', destinationId: 2, destinationName:'Riviera Maya', destinationUrl: 'riviera-maya', zoneName: 'Playa', countryName: 'México', category: 'Hotel'}
                        ,{ hotelId: 6, hotelName:'Hotel Cozumel', hotelUrl: 'hotel-cozumel', destinationId: 3, destinationName:'Cozumel', destinationUrl: 'cozumel', zoneName: 'Playa', countryName: 'México', category: 'Hotel'}
                        ,{ hotelId: 7, hotelName:'Hotel Puerto Vallarta', hotelUrl: 'hotel-puerto-vallarta', destinationId: 4, destinationName:'Puerto Vallarta', destinationUrl: 'puerto-vallarta', zoneName: 'Playa', countryName: 'México',category: 'Hotel'}
                    ]
                }
                for (var i = 0; i < data.destinations.length; i++) {
                    itemnamecodes.push({ 
                        label: data.destinations[i].destinationName, 
                        destinationId: data.destinations[i].destinationId,                       
                        destinationUrl: data.destinations[i].destinationUrl, 
                        category: "City" });
                }
                /*for (var j = 0; j < data.zones.length; j++) {
                    itemnamecodes.push({ label: data.zones[j].name, destination: data.zones[j].destinationId, tag: data.zones[j].destinationId, code: data.zones[j].destinationUrl, category: "Zonas" });
                }*/
                for (var k = 0; k < data.hotels.length; k++) {
                    itemnamecodes.push({ 
                        label: data.hotels[k].hotelName + ", " + data.hotels[k].destinationName + " - " + data.hotels[k].zoneName + ", " + data.hotels[k].countryName, 
                        destinationId: data.hotels[k].destinationId,
                        destinationUrl: data.hotels[k].destinationUrl,
                        hotelId: data.hotels[k].hotelId,                         
                        hotelUrl: data.hotels[k].hotelUrl, 
                        category: "Hotel" 
                    });
                }
                response(itemnamecodes);
                /*
                $.ajax({
                    crossDomain: true,
                    url: config.hotelEndpoint.destination + "?language=1&term=" + request.term,
                    method: "GET",
                    global: false,
                    success: function (data) {
                        for (var i = 0; i < data.destinations.length; i++) {
                            itemnamecodes.push({ label: data.destinations[i].name, destination: data.destinations[i].destinationId, tag: data.destinations[i].destinationId, code: data.destinations[i].destinationUri, category: "Ciudades" });
                        }
                        for (var j = 0; j < data.zones.length; j++) {
                            itemnamecodes.push({ label: data.zones[j].name, destination: data.zones[j].destinationId, tag: data.zones[j].destinationId, code: data.zones[j].destinationUri, category: "Zonas" });
                        }
                        for (var k = 0; k < data.hotels.length; k++) {
                            itemnamecodes.push({ label: data.hotels[k].hotelName + ", " + data.hotels[k].destinationName + " - " + data.hotels[k].zoneName + ", " + data.hotels[k].countryName, destination: data.hotels[k].destinationUri, tag: data.hotels[k].destinationId, code: data.hotels[k].hotelUri, category: "Hoteles" });
                        }
                        response(itemnamecodes);
                    }
                }).catch(function (error) {
                    if (error.statusText === 'error') {
                        swal({
                            title: "Error",
                            text: "Error en sistema",
                            button: {
                                text: "Ok"
                            },
                            types: 'error'
                        }).then(function () {
                            window.location = '/';
                        });
                    }
                });*/
            });
        },
        open: function() {
            var oldw = "";
            var neww = "";
            $("ul.ui-menu li").each(function () {
                if (oldw === "") {
                    if (typeof $(this).find("a").width() !== "undefined") {
                        oldw = $(this).find("a").width();
                    }
                } else {
                    if (typeof $(this).find("a").width() !== "undefined") {
                        neww = $(this).find("a").width();
                    }
                    if (neww > oldw) {
                        oldw = neww;
                    }
                }
            });
            $("ul.ui-menu").width(oldw + 45);
        },
        minLength: 3,
        focus: function (event, ui) {
            var menu = event.currentTarget;
            $("#" + menu.id).find("li").removeClass("ui-state-active");
            var focus = $("#" + menu.id).find("li:has(a.ui-state-active)");
            focus.addClass("ui-state-active");
            return false;
        },
        select: function (event, ui) {
            $(this).on("copy paste", function (e) {
                e.preventDefault();
            });
            if (ui.item.category === "Hotel") {                
                $(this).parent().find("input[name='destinationUrl']").val(ui.item.destinationUrl);
                $(this).parent().find("input[name='hotelId']").val(ui.item.hotelId);                
                $(this).parent().find("input[name='hotelUrl']").val(ui.item.hotelUrl);
            } else {
                $(this).parent().find("input[name='destinationId']").val(ui.item.destinationId);
                $(this).parent().find("input[name='destinationUrl']").val(ui.item.destinationUrl);                
                $(this).parent().find("input[name='hotelUrl']").val("");
            }                
            $("#sb-hotel .checkin").focus();
        }
    });
};

//Hotel Calendar (Init and End Date)
var HotelDatePicker = function () {
    var dateFormat = "dd/mm/yy";
    var today = new Date();
    var week = new Date();
    today.setDate(today.getDate() + 7);
    week.setDate(week.getDate() + 11);
    var initDateInput = $("#initdate").val();
    var endDateInput = $("#enddate").val();
    if (initDateInput === "" && endDateInput === "") {
        $("#initdate").val(("0" + today.getDate()).slice(-2) + '/' + ("0" + (today.getMonth() + 1)).slice(-2) + '/' + today.getFullYear());
        $("#enddate").val(("0" + week.getDate()).slice(-2) + '/' + ("0" + (week.getMonth() + 1)).slice(-2) + '/' + week.getFullYear());
    }
    //Date picker: Initial Date
    $('#initdate').datepicker({
        minDate: 2,
        numberOfMonths: 2,
        dateFormat: dateFormat,
        rangeSelect: true,
        showAnim: "slideDown",
        beforeShowDay: function (date) {
            var initDateInputValue = $(this).val();
            var endDateInputValue = $("#enddate").val();
            if (initDateInputValue !== "" && endDateInputValue !== "") {
                endDateInputValue = $.datepicker.parseDate(dateFormat, endDateInputValue);
                initDateInputValue = $.datepicker.parseDate(dateFormat, initDateInputValue);
                if (initDateInputValue <= date && date <= endDateInputValue) {
                    if (initDateInputValue.toString() === date.toString()) {
                        return [true, 'ui-state-highlight start-date', 'first'];
                    }
                    if (endDateInputValue.toString() === date.toString()) {
                        return [true, 'ui-state-highlight end-date', 'last'];
                    }
                    return [true, 'ui-state-highlight', 'test'];
                }
                return [true, '', ''];
            } else {
                return [true, '', ''];
            }
        },
        onSelect: function (dateStr) {
            var newD = $(this).datepicker("getDate");
            var min = $.datepicker.parseDate(dateFormat, dateStr);
            if (newD) {
                var date = newD;
                date.setDate(date.getDate() + 4);
            }
            $("#enddate").datepicker("setDate", date);
            $("#enddate").datepicker("option", "minDate", min);
        },
        onClose: function () {
            $("#enddate").focus();
        }
    });

    $('#enddate').datepicker({
        minDate: '7',
        numberOfMonths: 2,
        dateFormat: dateFormat,
        rangeSelect: true,
        showAnim: "slideDown",
        beforeShow: function () {
            $(this).datepicker('option', 'minDate', $("#initdate").datepicker('getDate'));
        },
        beforeShowDay: function (date) {
            var endDateInputValue = $(this).val();
            var initDateInputValue = $("#initdate").val();
            if (initDateInputValue !== "" && endDateInputValue !== "") {
                endDateInputValue = $.datepicker.parseDate(dateFormat, endDateInputValue);
                initDateInputValue = $.datepicker.parseDate(dateFormat, initDateInputValue);
                if (initDateInputValue <= date && date <= endDateInputValue) {
                    if (initDateInputValue.toString() === date.toString()) {
                        return [true, 'ui-state-highlight start-date', 'first'];
                    }
                    if (endDateInputValue.toString() === date.toString()) {
                        return [true, 'ui-state-highlight end-date', 'last'];
                    }
                    return [true, 'ui-state-highlight', 'test'];
                }
                return [true, '', ''];
            } else {
                return [true, '', ''];
            }
        },
        onSelect: function (dateStr) {
            $.datepicker.parseDate(dateFormat, dateStr);
        }
    });
};



//Hotel More Rooms
var HotelSearchMoreRooms = function () {
    $(".more-room").on('click', function (e) {
        e.preventDefault();
        var room = $(this).parents(".rooms").find(".box-modal .box-modal-clone .box-modal-inn:first").clone(); 
        var number = room.data("number");
        number++;
        room.find("label.title-room").text('Habitación' + " " + number);
        room.find(".delete-room").removeClass("d-none");
        room.find("input[name='adults']").val(1);
        room.find("input[name='children']").val(0);
        var ages = room.find(".children-ages:first").clone();
        room.find(".ages .row").html("");
        room.find(".ages .row").append(ages);
        room.find(".children-ages").addClass("d-none");
        room.removeAttr("data-number");
        $(this).parents(".rooms").find(".box-modal .box-modal-clone .box-modal-inn:first").removeAttr("data-number");
        $(this).parents(".rooms").find(".box-modal .box-modal-clone .box-modal-inn:first").attr("data-number", number);
        $(this).parents(".rooms").find(".box-modal .box-modal-clone").append(room);
    });
    $(".box-modal ").on("click", ".delete-room", function (e) {
        e.preventDefault();
        $(this).parents(".box-modal-inn").remove();
        var room = $(this).parents(".rooms").find(".box-modal .box-modal-clone .box-modal-inn:first").clone(); 
        var number = room.data("number");
        number--;
        $(this).parents(".rooms").find(".box-modal .box-modal-clone .box-modal-inn:first").removeAttr("data-number");
        $(this).parents(".rooms").find(".box-modal .box-modal-clone .box-modal-inn:first").attr("data-number", number);
    });
    $(".rooms").on("click", ".less-adults", function () {
        var adult = $(this).parent().find("input").val();
        if (adult > 1) {
            adult--;
        }
        $(this).parent().find("input").val(adult);
    });
    $(".rooms").on("click", ".more-adults", function () {
        var adult = $(this).parent().find("input").val();
        adult++;
        $(this).parent().find("input").val(adult);
    });
    $(".rooms").on("click", ".less-children", function () {
        var children = $(this).parent().find("input").val();
        if (children > 0) {
            children--;
            if (children == 0) {
                $(this).parents(".box-modal-inn").find(".children-ages").addClass("d-none");
            } else {
                $(this).parents(".box-modal-inn").find(".children-ages:last").remove();
            }
        }
        $(this).parent().find("input").val(children);
    });
    $(".rooms").on("click", ".more-children", function () {
        var children = $(this).parent().find("input").val();
        children++;
        if (children == 1) {
            $(this).parents(".box-modal-inn").find(".children-ages").removeClass("d-none");
        } else {
            var ages = $(this).parents(".box-modal-inn").find(".children-ages:first").clone();
            ages.find("label").text("Edad" + " (" + "Niño" + " " + children + ")");
            $(this).parents(".box-modal-inn").find(".ages .row").append(ages);
        }
        $(this).parent().find("input").val(children);
    });
}

//Hotel Buttom
var HotelSearchButton = function () {
    $(".search-hotels").on("click", function (e) {
        e.preventDefault();
        var destinationUri = $("#sb-hotel input[name='service-uri']").val();
        var destinationId = $("#sb-hotel input[name='service-id']").val();
        var hotelUri = $("#sb-hotel input[name='hotel-uri']").val();
        var checkIn = $("#sb-hotel .checkin").val();
        var checkOut = $("#sb-hotel .checkout").val();
        var sessionId = $("input[name='sid']").val();
        var occupancy = "";
        if (typeof destinationUri === 'undefined') {
            destination = "";
        }
        if (typeof checkIn === 'undefined') {
            checkIn = "";
        }
        if (typeof checkOut === 'undefined') {
            checkOut = "";
        }
        if (checkIn !== "" && checkOut !== "") {
            checkIn = checkIn.split("/");
            checkIn = checkIn[2] + "-" + checkIn[1] + "-" + checkIn[0];
            checkOut = checkOut.split("/");
            checkOut = checkOut[2] + "-" + checkOut[1] + "-" + checkOut[0];
        }
        if (destinationUri !== "") {
            $(".loader-page").css("display", "block");
            $("#sb-hotel .rooms .box-modal .box-modal-clone .box-modal-inn").each(function () {
                var adults = $(this).find("input[name='adults']").val();
                var children = $(this).find("input[name='children']").val();
                if (occupancy !== "" && typeof adults !== "undefined") {
                    occupancy = occupancy + "!" + adults;
                } else {
                    if (typeof adults !== "undefined") {
                        occupancy = occupancy + adults;
                    }
                }
                if (children > 0) {
                    $(this).find(".children-ages select").each(function () {
                        var ages = $(this).val();
                        if (typeof ages !== "undefined") {
                            occupancy = occupancy + "-" + ages;
                        }
                    });
                }
            });
            var isHotel = false;
            var destinationLower = destinationUri.toLowerCase();
            var url =  "/" + lang.hotels + "-" + lang.in + "-" + destinationLower + "/";
            if (hotelUri !== "") {
                url = url + hotelUri + "/";
                isHotel = true
            }
            url = url + checkIn + "/" + checkOut + "/" + occupancy + "?sid=" + sessionId;
            //if (isHotel) {
            //    url = config.actionUrlOwnDetail + url;
            //} else {
            //    url = config.actionUrlOwn + url;
            //}
            window.location.href = url;
        } else {
            swal({
                title: "Información Incompleta",
                text: "Para una mejor búsqueda, seleccione su destino",
                button: {
                    text: "Aceptar"
                }
            });
        }
    });
}
$(document).ready(function() {
    HotelAutoComplete();
    HotelDatePicker();
    HotelSearchMoreRooms();
    HotelSearchButton();
})
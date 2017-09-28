function fixNavigation() {
    var example = window.location.href.split("=")[1].split("&")[0];
    var currentLink = exampleToHyphens(example);
    var sideBar = $(".nav-sidebar");
    var sideBarLinks = sideBar.find("li a");

    $(".nav-sidebar li, .nav-sidebar li div").removeClass('active');

    sideBar.find("ul").css("display", "none");

    $(".nav-sidebar li a").each(function (index, link) {
        var href = $(link).attr("aria-label");
        var hrefSplitArray = href.split("/");
        var hrefTag = hrefSplitArray[hrefSplitArray.length - 1];

        if (currentLink == hrefTag) {


            $(link).parent().addClass("active");
            $(link).parent().parent().css("display", "block");
            $(link).parent().parent().parent().addClass("active").children('div').addClass('active');

            $(".demo-name").html($(link).text());

            if (index < $(".nav-sidebar li a").length - 1) {
                var nextHref = $(sideBarLinks.get(index + 1)).attr("href");
                $(".chart-container").find("#next-example").attr("href", nextHref);
                $("#chart-switcher").find("#next-example").attr("href", nextHref);
            }

            if (index > 0) {
                var prevHref = $(sideBarLinks.get(index - 1)).attr("href");
                $(".chart-container").find("#previous-example").attr("href", prevHref);
                $("#chart-switcher").find("#previous-example").attr("href", prevHref);
            }
        }
    });
}
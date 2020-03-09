function hookHandlers() {
    $(".testController").on("click", function (e) {
        var blogpost = {
            siteId: $('.siteID').val(), 
            title: $('.Title').val(),
            langCode: $('.langCode').val(),
            metaDescription: $('.metaDescription').val(),
            content: tinymce.editors.mytextarea.getContent(),
            url: $('.URL').val(),
            showInHp: $('.showInHP').val(),
            label: $('.label').val(),
            status: $('.status:checked').val(),
            metaTags: $('.metaTag').val(),
            redirectUrl: $('.redirectURL').val(),
            redirectionType: $('.redirectionType').val(),
            seoscore: $('#seoScoreId').val(),
            coverImageUrl: $('.coverImageURL').val(),
            tags: $('.tags').val(),
            headerTags: $('.headerTags').val(),
            categories: $('.categories').val(),
            homePageImageUrl: $('.HPInputURL').val(),
            coverImageAlt: $('.coverPhotoALT').val(),
            homePageImageAlt: $('.HPImageAlt').val(),
            associatedProducts: $('.associatedProducts').val(),
            showInPdpcategories: $('.showInPDPCategories').val(),
            showInPdpproducts: $('.showInPDPProducts').val()
        };

        $.ajax("/Post/Create", {
            async: false,
            type: "POST",
            data: { blogpost: blogpost },
            success: function (data) {
                window.location.href = "/Post/Edit/" + data.blogId
            },
            fail: function (data) {
                console.log('failed');
            }
        })
    });
}


$(function () {
    tinymce.init({
        selector: '#mytextarea',
        height: 500,
        plugins: [
            "advlist autolink lists link image charmap print preview anchor",
            "searchreplace visualblocks code fullscreen",
            "insertdatetime media table paste imagetools wordcount"
        ],
        toolbar: "insertfile undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image",
        content_css: [
            '//fonts.googleapis.com/css?family=Lato:300,300i,400,400i',
            '//www.tiny.cloud/css/codepen.min.css'
        ]
    });
    hookHandlers();
});
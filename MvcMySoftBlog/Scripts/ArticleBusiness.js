//本页面默认加载了jQuery
var Article = {
    Save: function (title, content) {
        ///<field name="title">标题</field>
        ///<field name="content">文章html内容</field>
        $.post("/Article/Create", { "title": title, "content": content }, function (data) {
            if (data) {
                location.href = data.redirect;
            }
        });
    }
};
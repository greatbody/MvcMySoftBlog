//本页面默认加载了jQuery
var Article = {
    Save: function (title, content, id) {
        ///<field name="title">标题</field>
        ///<field name="content">文章html内容</field>
        if (!id) {
            $.post("/Article/Create", { "title": title, "content": content, "id": id }, function (data) {
                if (data) {
                    location.href = data.redirect;
                }
            });
        } else {
            $.post("/Article/Edit", { "id": id, "title": title, "content": content }, function (data) {
                if (data) {
                    if (data.result == true) {
                        location.href = data.redirect;
                    } else {
                        alert("保存错误！");
                    }
                }
            });
        }

    },
    SaveCaoGao: function (title, content, id) {
        ///<field name="title">标题</field>
        ///<field name="content">文章html内容</field>
        if (!id) {
            id = -1;
        }
        $.post("/Article/Create", { "title": title, "content": content, IsCaoGao: 1, "id": id }, function (data) {
        });
    },
    Zan: function (id,oRef) {
        ///<summary>点赞</summary>
        $.post("/Article/VotePro", { "id": id }, function (data) {
            if (data.result==true) {
                var nNum = parseInt($(oRef).find("span").text(), 10);
                $(oRef).find("span").text(nNum + 1);
            }
        });
    },
    Cai: function (id,oRef) {
        ///<summary>踩</summary>
        $.post("/Article/VoteCon", { "id": id }, function (data) {
            if (data.result == true) {
                var nNum = parseInt($(oRef).find("span").text(), 10);
                $(oRef).find("span").text(nNum + 1);
            }
        });
    }
};
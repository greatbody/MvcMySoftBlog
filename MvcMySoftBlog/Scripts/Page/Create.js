var Timer = {
    nCount: 0,
    oTimerIDs: [],
    nTimerId: 0,
    ExecOnce: function (funcid) {
        if (oTimerIDs[funcid].Limit == 0) {
            //只要归零了，肯定是定时的，对于这种，就得关闭
            clearInterval(oTimerIDs[funcid].TimerID);
        }
    },
    add: function (nSec, oFunction, sName, nTimes) {
        ///<param name="nSec">延迟时间，毫秒</param>
        ///<param name="oFunction">调用函数</param>
        ///<param name="sName">定时器名称（可选，不填则定时器无名字）</param>
        ///<param name="nTimes">循环次数（可选，不填表示无限循环）</param>
        ///<summary>根据各个参数来创建，基础的参数是nSec和oFunction</summary>
        var nParams = arguments.length;
        var obj;
        var oFunc;
        var nTimerId;
        switch (nParams) {
            case 2:
                //两个参数，自动增加
                nTimerId = setInterval(oFunction, nSec);
                obj = {
                    ID: Timer.nCount,
                    TimerID: nTimerId,
                    Name: String(nCount),
                    Interval: nSec,
                    Limit: -1
                };
                Timer.oTimerIDs.push(obj);
                break;
            case 3:
                //三个参数
                nTimerId = setInterval(oFunction, nSec);
                obj = {
                    ID: Timer.nCount,
                    TimerID: nTimerId,
                    Name: sName,
                    Interval: nSec,
                    Limit: -1
                };
                Timer.oTimerIDs.push(obj);
                break;
            case 4:
                //四个参数
                obj = {
                    ID: Timer.nCount,
                    TimerID: 0,
                    Name: sName,
                    Interval: nSec,
                    Limit: nTimes
                };
                oFunc = function (oThis, oMyFunc) {
                    var oThat = oThis;
                    var oMyFun = oMyFunc;
                    var oRun = function () {
                        if (oThat.Limit > 0 || oThat.Limit == -1) {
                            oMyFun(); //执行传入的函数
                            if (oThat.Limit > 0) oThat.Limit--;
                        } else {
                            //自行了断
                            clearInterval(oThat.TimerID);
                        }
                    };
                    return oRun;
                };
                nTimerId = setInterval(oFunc(obj, oFunction), nSec);
                obj.TimerID = nTimerId;
                Timer.oTimerIDs.push(obj);
                break;
            case 5:
                //5个参数
                obj = {
                    ID: Timer.nCount,
                    TimerID: 0,
                    Name: sName,
                    Interval: nSec,
                    Limit: nTimes
                };
                oFunc = function (oThis, oMyFunc, callback) {
                    var oThat = oThis;
                    var oMyFun = oMyFunc;
                    var oExFunc = callback;
                    var oRun = function () {
                        if (oThat.Limit > 0 || oThat.Limit == -1) {
                            oMyFun(); //执行传入的函数
                            oExFunc();
                            if (oThat.Limit > 0) oThat.Limit--;
                        } else {
                            //自行了断
                            clearInterval(oThat.TimerID);
                        }
                    };
                    return oRun;
                };
                nTimerId = setInterval(oFunc(obj, oFunction, arguments[4]), nSec);
                obj.TimerID = nTimerId;
                Timer.oTimerIDs.push(obj);
                break;
            default:
                return;
        }
    },
    CloseTimer: function (sTimerName) {
        ///<param name="sTimerName">计时器的名字，或ID</param>
        if (typeof (sTimerName) == "number") {
            //按照数字方法关闭
            for (var j = 0; j < Timer.oTimerIDs.length; j++) {
                if (Timer.oTimerIDs[j].ID == sTimerName) {
                    clearInterval(Timer.oTimerIDs[j].TimerID);
                    Timer.oTimerIDs = Timer.oTimerIDs.splice(j, 1);
                    Timer.nCount--;
                    break;
                }
            }
        } else {
            //按照字符串方式关闭
            for (var m = 0; m < Timer.oTimerIDs.length; m++) {
                if (Timer.oTimerIDs[m].Name == sTimerName) {
                    clearInterval(Timer.oTimerIDs[m].TimerID);
                    Timer.oTimerIDs.splice(m, 1);
                    Timer.nCount--;
                    break;
                }
            }
        }
    },
    Timers: function (timerId, delegatefunc) {
        var oTree = Timer.oTimerIDs;
        for (var nIndex = 0; nIndex < oTree.length; nIndex++) {
            if (typeof timerId == "number") {
                if (oTree[nIndex].ID == timerId) {
                    if (typeof delegatefunc == "function") {
                        delegatefunc();
                    }
                    return oTree[nIndex];
                }
            } else {
                if (oTree[nIndex].Name == timerId) {
                    if (typeof delegatefunc == "function") {
                        delegatefunc();
                    }
                    return oTree[nIndex];
                }
            }
        }
        return null;
    }
};
var oUE;
$(document).ready(function () {
    oUE = new UE.ui.Editor({ innerHeight: "600px", innerWidth: "100%" });
    oUE.render("container");
    Timer.add(200, function () {
        var oContainer = $("#edui1");
        if (oContainer.length > 0) {
            oContainer.addClass("myform-control");
            Timer.CloseTimer("update");
        }
    }, "update");
    Timer.add(500, function () {
        var oIframe = $("#edui1_iframeholder");
        if (oIframe.length > 0) {
            if (oIframe.css("height") == "155px") {
                oIframe.css("height", "300px");
            }
        }
    }, "heightsetter");
    $("#btnPreview").click(function () {
        btnControl.preView();
    });
    $("#btnSubmit").click(function () {
        btnControl.postNew();
    });
});


var btnControl = {
    preView: function () {
        oUE.execCommand("preview");
    },
    postNew:function() {
        //提交新日志
        var sContent = oUE.getContent();
        var sTitle = $("#ArticleTitle").val();
        Article.Save(sTitle, sContent);
    },
    postCaoGao:function() {
        //提交草稿
    }
};

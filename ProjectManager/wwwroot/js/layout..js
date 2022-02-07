const minWidth = 768;
const signUnBtn = document.getElementById('sign-up');
(function() {
    var throttle = function(type, name, obj) {
        obj = obj || window;
        var running = false;
        var func = function() {
            if (running) { return; }
            running = true;
            requestAnimationFrame(function() {
                obj.dispatchEvent(new CustomEvent(name));
                running = false;
            });
        };
        obj.addEventListener(type, func);
    };
    throttle("resize", "optimizedResize");
})();
function changeAuthBtn(){
    if(signUnBtn){
        if(window.innerWidth <= minWidth){ //width of page fewer minimal width
            if(!signUnBtn.classList.contains('hide')){
                console.log("change btn");
                signUnBtn.classList.add('hide')
            }
        }
        else if(signUnBtn.classList.contains('hide')){
            signUnBtn.classList.remove('hide')
        }
    }
}
window.addEventListener('optimizedResize', changeAuthBtn);
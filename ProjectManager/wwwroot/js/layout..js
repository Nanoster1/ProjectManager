const minWidth = 768;
const signInBtn = document.getElementById('sign-in');
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
    if(signInBtn){
        if(window.innerWidth <= minWidth){ //width of page fewer minimal width
            if(!signInBtn.classList.contains('hide')){
                console.log("change btn");
                signInBtn.classList.add('hide')
            }
        }
        else if(signInBtn.classList.contains('hide')){
            signInBtn.classList.remove('hide')
        }
    }
}
window.addEventListener('optimizedResize', changeAuthBtn);
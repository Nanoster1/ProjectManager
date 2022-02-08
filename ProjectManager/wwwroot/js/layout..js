const minWidth = 768;
const signInBtn = document.getElementById('sign-in');
const footer = document.getElementById('footer');
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
function addButtons(){
    let sections = footer.getElementsByTagName('section');
    if(sections){
        for (let section in sections){
            addBtnForli(section);
        }
    }
}
function addBtnForli(section){
    var btn = document.createElement('button')
    var p = section.getElementsByTagName('p')[0];
    if(p){
        btn.appendChild(p);
        section.removeChild(p)
    }
    section.appendChild(btn);
}
window.addEventListener('optimizedResize', changeAuthBtn);
window.addEventListener('optimizedResize', addButtons)
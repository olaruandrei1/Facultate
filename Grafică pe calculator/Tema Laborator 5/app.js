function()

const scene = new THREE.Scene();

const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);

const renderer = new THREE.WebGLRenderer({antialias: true}); //{antialias: true} o pun dupa afisarea cubului -> pentru a avea laturile mai bine definite sau ascutite

renderer.setSize(window.innerWidth, window.innerHeight);

document.body.appendChild(renderer.domElement); //Vanilla JavaScript

const geometry = new THREE.Triangle( 3,  3, 3); 
const material = new THREE.MeshBasicMaterial( {color: 0xff0000} );
const triangle = new THREE.Mesh( geometry, material );
scene.add( triangle );

camera.position.z = 5; // daca nu punem asta, camera va fi in cub

// Fara aceasta functie nu va afisa nimic
function animate() {
    
    renderer.render(scene, camera);
}

animate();

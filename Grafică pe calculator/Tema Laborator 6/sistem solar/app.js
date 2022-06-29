
let scene, camera, renderer, soare,mercur,venus,terra,marte,jupiter,saturn,uranus,neptun;

function init() {
    scene = new THREE.Scene();

    camera=new THREE.PerspectiveCamera(75,window.innerWidth/window.innerHeight,0.1,1000);

    renderer = new THREE.WebGLRenderer({antialias: true});
    renderer.setSize(window.innerWidth, window.innerHeight);

    document.body.appendChild(renderer.domElement);
    // soare
    var geometry = new THREE.SphereGeometry( 8, 52, 40 ); 

    //const material = new THREE.MeshBasicMaterial( {color: 0xff0000} );
    //cube = new THREE.Mesh( geometry, material );

    var texture = new THREE.TextureLoader().load('sun.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    soare = new THREE.Mesh( geometry, material );
    scene.add( soare );

    //mercur
    var geometry = new THREE.SphereGeometry( 2, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('mercur.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    mercur = new THREE.Mesh( geometry, material );
    
    mercur.position.x = 12;

    mercur.position.y = 0;

    mercur.position.z = 1;
    scene.add( mercur );

    //venus
    var geometry = new THREE.SphereGeometry( 3, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('venusmer.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    venus = new THREE.Mesh( geometry, material );
    venus.position.x = 18;

    venus.position.y = 0;

    venus.position.z = 1;
    scene.add( venus );

    //terra
    var geometry = new THREE.SphereGeometry( 3, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('earthmab.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    terra = new THREE.Mesh( geometry, material );
    terra.position.x = 25;

    terra.position.y = 0;

    terra.position.z = 1;
    scene.add( terra );
 
    //marte
    var geometry = new THREE.SphereGeometry( 2, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('mars.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    marte = new THREE.Mesh( geometry, material );
    marte.position.x = 28;

    marte.position.y = 0;

    marte.position.z = 9;
    scene.add( marte );

    //jupiter
    var geometry = new THREE.SphereGeometry( 6, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('jupeqsm.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    jupiter = new THREE.Mesh( geometry, material );
    jupiter.position.x = 45;

    jupiter.position.y = 0;

    jupiter.position.z = 1;
    scene.add( jupiter );
    
    //saturn
    var geometry = new THREE.SphereGeometry( 6, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('sat0fds1-copy-100-75.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    saturn = new THREE.Mesh( geometry, material );
    saturn.position.x = 60;

    saturn.position.y = 0;

    saturn.position.z = 4;
    scene.add( saturn );
    //uranus
    var geometry = new THREE.SphereGeometry( 4, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('uranus.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    uranus = new THREE.Mesh( geometry, material );
    uranus.position.x = 79;

    uranus.position.y =0;

    uranus.position.z = 1;
    scene.add( uranus );
    //neptun
    var geometry = new THREE.SphereGeometry( 4, 11, 23 ); 

    var texture = new THREE.TextureLoader().load('nep0fds1-copy-100-75.jpg');
    var material = new THREE.MeshBasicMaterial( {map: texture} );
    neptun = new THREE.Mesh( geometry, material );
    neptun.position.x = 89;

    neptun.position.y = 0;

    neptun.position.z = 1;
    scene.add( neptun );
    camera.position.z = 57;
    camera.position.y = 10;
    camera.rotation.x = -25;
    

    soare.add(mercur);
    soare.add(venus);
    soare.add(terra);
    soare.add(marte);
    soare.add(jupiter);
    soare.add(saturn);
    soare.add(uranus);
    soare.add(neptun);
}

function onWindowResize() {
    camera.aspect = window.innerWidth / window.innerHeight;
    camera.updateProjectionMatrix();
    renderer.setSize(window.innerWidth, window.innerHeight);
}

function animate() {
    requestAnimationFrame(animate);

    // soare.rotation.x += 0.005;
    soare.rotation.y += 0.001;
    mercur.rotation.y += 0.05;
    venus.rotation.y += 0.03;
    terra.rotation.y += 0.02;
    marte.rotation.y += 0.01;
    jupiter.rotation.y += 0.005;
    saturn.rotation.y += 0.005;
    uranus.rotation.y += 0.007;
    neptun.rotation.y += 0.006;


    // cube2.rotation.x += 0.05;
    // cube2.rotation.y += 0.005;

    // cube3.rotation.x += 0.003;
    // cube3.rotation.y += 0.002;

    // cube5.rotation.x += 0.001;
    // cube5.rotation.y += 0.01;

    // cube4.rotation.x += 0.05;
    // cube4.rotation.y += 0.05;

    // cube6.rotation.x += 0.15;
    // cube6.rotation.y += 0.105;

    renderer.render(scene, camera);
}

// se apeleaza functia onWindowResize() cand facem resize la pagina
window.addEventListener('resize', onWindowResize, false); 

init();
animate();

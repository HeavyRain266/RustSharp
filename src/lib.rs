#[no_mangle]
pub fn add(left: usize, right: usize) -> usize {
    left + right
}

#[no_mangle]
pub fn hello(text: &str) {
    println!("Hello, {text}");
}

#[no_mangle]
pub fn is_bool(i: i32) -> bool {
    i < 100
}

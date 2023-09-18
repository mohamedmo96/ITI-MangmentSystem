const ITEMS=[
    {
    id: 1,
    name: 'Iphone 8',
    price:800,
    image: './New folder/Apple_iPhone_14-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 2,
    name: 'Iphone 9',
    price:900,
    image: './New folder/p1-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 3,
    name: 'Iphone X',
    price:1000,
    image: './New folder/Apple_iPhone_14-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 4,
    name: 'Iphone 11',
    price:1100,
    image: './New folder/p1-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 5,
    name: 'Iphone 12',
    price:1200,
    image: './New folder/Apple_iPhone_14-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 6,
    name: 'Iphone 13',
    price:1300,
    image: './New folder/p1-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 7,
    name: 'Iphone 14',
    price:1400,
    image: './New folder/Apple_iPhone_14-removebg-preview.png',
    qty: 1
    },
    
    {
    id: 8,
    name: 'Iphone 14 Pro Max',
    price:1500,
    image: './New folder/p1-removebg-preview.png',
    qty: 1
    },
  
    {
    id: 9,
    name: 'Apple Headset 2016',
    price:800,
    image: './New folder/36.png',
    qty: 1
    },
  
    {
    id: 10,
    name: 'Apple Headset 2017',
    price:900,
    image: './New folder/31.png',
    qty: 1
    },
  
    {
    id: 11,
    name: 'Apple Headset 2018',
    price:1000,
    image: './New folder/36.png',
    qty: 1
    },
  
    {
    id: 12,
    name: 'Apple Headset 2019',
    price:1100,
    image: './New folder/31.png',
    qty: 1
    },
  
    {
    id: 13,
    name: 'Apple Headset 2020',
    price:1200,
    image: './New folder/36.png',
    qty: 1
    },
  
    {
    id: 14,
    name: 'Apple Headset 2021',
    price:1300,
    image: './New folder/31.png',
    qty: 1
    },
  
    {
    id: 15,
    name: 'Apple Headset 2022',
    price:1400,
    image: './New folder/36.png',
    qty: 1
    },
  
    {
    id: 16,
    name: 'Apple Headset 2023',
    price:1500,
    image: './New folder/31.png',
    qty: 1
    },
  
    {
    id: 17,
    name: 'Apple Watch S1',
    price:800,
    image: './New folder/41.png',
    qty: 1
    },
  
    {
    id: 18,
    name: 'Apple Watch S2',
    price:900,
    image: './New folder/42.png',
    qty: 1
    },
  
    {
    id: 19,
    name: 'Apple Watch S3',
    price:1000,
    image: './New folder/43.png',
    qty: 1
    },
  
    {
    id: 20,
    name: 'Apple Watch S4',
    price:1100,
    image: './New folder/44.png',
    qty: 1
    },
  
    {
    id: 21,
    name: 'Apple Watch S5',
    price:1200,
    image: './New folder/42.png',
    qty: 1
    },
  
    {
    id: 22,
    name: 'Apple Watch S6',
    price:1300,
    image: './New folder/43.png',
    qty: 1
    },
  
    {
    id: 23,
    name: 'Apple Watch S7',
    price:1400,
    image: './New folder/41.png',
    qty: 1
    },
  
    {
    id: 24,
    name: 'Apple Watch S8',
    price:1500,
    image: './New folder/44.png',
    qty: 1
    },
  
    {
    id: 25,
    name: 'Mac-book 2015',
    price:800,
    image: './New folder/62.png',
    qty: 1
    },
  
    {
    id: 26,
    name: 'Mac-book 2016',
    price:900,
    image: './New folder/63.png',
    qty: 1
    },
  
    {
    id: 27,
    name: 'Mac-book 2017',
    price:1000,
    image: './New folder/61.png',
    qty: 1
    },
  
    {
    id: 28,
    name: 'Mac-book 2018',
    price:1100,
    image: './New folder/63.png',
    qty: 1
    },
  
    {
    id: 29,
    name: 'Mac-book 2019',
    price:1200,
    image: './New folder/62.png',
    qty: 1
    },
  
    {
    id: 30,
    name: 'Mac-book 2020',
    price:1300,
    image: './New folder/61.png',
    qty: 1
    },
  
    {
    id: 31,
    name: 'Mac-book 2021',
    price:1400,
    image: './New folder/63.png',
    qty: 1
    },
  
    {
    id: 32,
    name: 'Mac-book 2022',
    price:1500,
    image: './New folder/62.png',
    qty: 1
    },
  
  ]
  
  
  const openBtn= document.getElementById("open_cart_btn")
  const cart= document.getElementById("sidecart")
  const closeBtn= document.getElementById("close_btn")
  const backdrop= document.querySelector('.backdrop')
  const itemsEl=document.querySelector('.items')
  const cartItems=document.querySelector('.cart_items')
  const itemsNum=document.getElementById('items_num')
  const subtotalPrice=document.getElementById('subtotal_price')
  
  
  let cart_data =[]
  
  openBtn.addEventListener("click", openCart)
  closeBtn.addEventListener("click", closeCart)
  backdrop.addEventListener("click", closeCart)
  
  renderItems()
  renderCartItems()
  
  //Open the cart
  function openCart(params) {
    cart.classList.add('open')
    backdrop.style.display='block'
    setTimeout(()=>{
        backdrop.classList.add('show')
    },0)
  }
  
  //Close the cart
  function closeCart(params) {
    cart.classList.remove('open')
    backdrop.classList.remove('show')
  
    setTimeout(()=>{
        backdrop.style.display='none'
    },500);
  }
  
  
  //Add Item to the cart
  function addItem(idx,itemId) {
    //find same items
    const foundedItem =cart_data.find(item => item.id.toString() === itemId.toString())
  
    if(foundedItem){
        //increase qty
        increaseQty(itemId)
    }else{
        cart_data.push(ITEMS[idx])
    }
    updateCart()
    openCart()
  }
  
  //Remove cart itemes
  function removeCartItem(itemId){
    cart_data = cart_data.filter(item => item.id !=itemId)
  
    updateCart()
  }
    
  //Increase qty
  function increaseQty(itemId){
    cart_data = cart_data.map(item => item.id.toString() === itemId.toString() ? {...item, qty: item.qty + 1} :item)
    updateCart()
  }
  
  //Decrease qty
  function decreaseQty(itemId){
    cart_data = cart_data.map(item => item.id.toString() === itemId.toString() ? {...item, qty: item.qty > 1? item.qty -1 :item.qty} :item)
    updateCart()
  }
  
  
  //Clear cart
  function clearCart(){
    cart_data = ""
    itemsNum.innerText=0
    subtotalPrice.innerText=0
    updateCart()
  }
  
  //Calculate items
  function calcItemsNum(){
    let itemsCount = 0
  
    cart_data.forEach((item => itemsCount += item.qty))
  
    itemsNum.innerText = itemsCount
  }
  
  
  //Calculate Subtotal
  function calcSubtotalPrice(){
    let subtotal = 0
  
    cart_data.forEach((item) => (subtotal += item.price * item.qty))
  
    subtotalPrice.innerText = subtotal
  }
  
  
  //Render items
  function renderItems() {
    ITEMS.forEach((item,idx) =>{
    const itemEl=document.createElement('div')
    itemEl.classList.add('item')
    if(item.id <= 8){
      itemEl.id="Iphone"
    }
    if(item.id > 8 && item.id <=16){
      itemEl.id="Headset"
    }
    if(item.id > 16 && item.id <=24){
      itemEl.id="Watch"
    }
    if(item.id > 24 && item.id <=32){
      itemEl.id="laptop"
    }
    itemEl.onclick = () => addItem(idx, item.id)
  
    if(item.id <= 8){
    itemEl.innerHTML=
    `
    <img src="${item.image}" alt="" />
    <br>
    <h4 >${item.name}</h4>
      <p >$ ${item.price}</p>
      <br>
    <button>
        <span class="IconContainer"> 
            <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 576 512" fill="rgb(17, 17, 17)" class="cart"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"></path></svg>
        </span>
        <p class="text">Add to Cart</p>
    </button>
  
    `
  }
    if(item.id > 8 && item.id <=16){
    itemEl.innerHTML=
    
    `
    <div id="Headset">
    <img src="${item.image}" alt="" />
    <br>
    <h4 >${item.name}</h4>
      <p >$ ${item.price}</p>
      <br>
    <button>
        <span class="IconContainer"> 
            <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 576 512" fill="rgb(17, 17, 17)" class="cart"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"></path></svg>
        </span>
        <p class="text">Add to Cart</p>
    </button>
    </div>
    `
  }
    if(item.id > 16 && item.id <=24){
    itemEl.innerHTML=
    
    `
    <div id="itemm">
    <img src="${item.image}" alt="" />
    <br>
    <h4 >${item.name}</h4>
      <p >$ ${item.price}</p>
      <br>
    <button>
        <span class="IconContainer"> 
            <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 576 512" fill="rgb(17, 17, 17)" class="cart"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"></path></svg>
        </span>
        <p class="text">Add to Cart</p>
    </button>
    </div>
    `
  }
    if(item.id > 24 && item.id <=32){
    itemEl.innerHTML=
    
    `
    <div id="itemm">
    <img src="${item.image}" alt="" />
    <br>
    <h4 >${item.name}</h4>
      <p >$ ${item.price}</p>
      <br>
    <button>
        <span class="IconContainer"> 
            <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 576 512" fill="rgb(17, 17, 17)" class="cart"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"></path></svg>
        </span>
        <p class="text">Add to Cart</p>
    </button>
    </div>
    `
  }
    if(item.id <= 8){
    itemEl.innerHTML=
    
    `
    <div id="itemm">
    <img src="${item.image}" alt="" />
    <br>
    <h4 >${item.name}</h4>
      <p >$ ${item.price}</p>
      <br>
    <button>
        <span class="IconContainer"> 
            <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 576 512" fill="rgb(17, 17, 17)" class="cart"><path d="M0 24C0 10.7 10.7 0 24 0H69.5c22 0 41.5 12.8 50.6 32h411c26.3 0 45.5 25 38.6 50.4l-41 152.3c-8.5 31.4-37 53.3-69.5 53.3H170.7l5.4 28.5c2.2 11.3 12.1 19.5 23.6 19.5H488c13.3 0 24 10.7 24 24s-10.7 24-24 24H199.7c-34.6 0-64.3-24.6-70.7-58.5L77.4 54.5c-.7-3.8-4-6.5-7.9-6.5H24C10.7 48 0 37.3 0 24zM128 464a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zm336-48a48 48 0 1 1 0 96 48 48 0 1 1 0-96z"></path></svg>
        </span>
        <p class="text">Add to Cart</p>
    </button>
    </div>
    `
  }
    itemsEl.appendChild(itemEl)
    
  })
  }
  
  
  
  //Display /Render Cart Items
  
  function renderCartItems() {
  //remove every thing from cart
  cartItems.innerHTML= ''
  //add new data
  cart_data.forEach((item) =>{
    const cartItem = document.createElement('div')
    cartItem.classList.add('cart_item')
    cartItem.innerHTML=`   
    <div class="remove_item" onclick= "removeCartItem(${item.id})" >
    <span>&times;</span>
  </div>
  <div class="item_img">
    <img src="${item.image}" alt="" />
  </div>
  <div class="item_details">
    <p>${item.name}</p>
    <strong>$${item.price}</strong>
    <div class="qty">
        <span class="minus" onclick="decreaseQty(${item.id})">-</span>
        <strong>${item.qty}</strong>
        <span class="blus" onclick=" increaseQty(${item.id})" >+</span>
    </div>
  </div>
  `
    cartItems.appendChild(cartItem)
  })
  }
  
  
  
  function updateCart() {
    //render cart items with the updated data
    renderCartItems()
    //Update Items Number in Cart
    calcItemsNum()
    //Update subtotal in Cart
    calcSubtotalPrice()
  }
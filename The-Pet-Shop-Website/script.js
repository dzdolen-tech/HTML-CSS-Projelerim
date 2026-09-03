function openLightbox(src, alt) {
  const modal = document.getElementById('lightboxModal');
  const modalImg = document.getElementById('lightboxImg');
  const captionText = document.getElementById('caption');
  
  modal.style.display = 'block';
  modalImg.src = src;
  captionText.innerHTML = alt;
}

function closeLightbox() {
  document.getElementById('lightboxModal').style.display = 'none';
}
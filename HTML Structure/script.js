document.addEventListener('DOMContentLoaded', () => {
  const modal = document.getElementById('lightboxModal');
  const lightboxImg = document.getElementById('lightboxImg');
  const captionText = document.getElementById('caption');
  const closeBtn = document.querySelector('.close-btn');
  const triggers = document.querySelectorAll('.lightbox-trigger');

  // Open lightbox on click
  triggers.forEach(img => {
    img.addEventListener('click', () => {
      modal.style.display = 'flex';
      lightboxImg.src = img.src;
      captionText.innerHTML = img.alt;
    });
  });

  // Close lightbox on clicking 'X' or background
  const closeModal = () => modal.style.display = 'none';
  closeBtn.addEventListener('click', closeModal);
  modal.addEventListener('click', (e) => {
    if (e.target === modal) closeModal();
  });
});
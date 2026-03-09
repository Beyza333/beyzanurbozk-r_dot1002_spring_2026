//C# Coding Exercises - Design Principles 2
void Jump() {
    PlaySfx(jumpSound, 0.9f, 1.1f); // Ses klibi ve rastgele pitch aralığı
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot() {
    PlaySfx(shootSound, 0.8f, 1.2f);
    Instantiate(bullet);
}

// Ses çalma mantığını tek bir yerde topladık
void PlaySfx(AudioClip clip, float minPitch = 1f, float maxPitch = 1f) {
    AudioSource audio = GetComponent<AudioSource>();
    audio.pitch = Random.Range(minPitch, maxPitch); // Pitch varyasyonu eklendi
    audio.clip = clip;
    audio.Play();
}
//I used AI to help me.

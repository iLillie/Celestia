<template>
  <li class="li-item">
    <a :href="href" :target="target" >
      <span :class="icon"></span>
      <div  :class="{ collapse: collapse}">
        <slot/>
      </div>
    </a>
  </li>
</template>

<script>
export default {
  name: "MenuItem",
  props: {
    icon: {
      type: String,
      default: ""
    },
    href: {
      type: String,
      default: ""
    },
    target: {
      type: String,
      default: ""
    },
    collapse: {
      type: Boolean,
      default: false
    }
  }
}
</script>

<style scoped>
  a {
    transition: background-color 500ms ease-in-out;
    @apply flex bg-transparent gap-2.5 p-4 font-sans items-center text-lg font-medium text-gray-600;
  }

  a:hover {
    @apply bg-gray-300;
  }

  .collapse {
    display: none;
  }


</style>
